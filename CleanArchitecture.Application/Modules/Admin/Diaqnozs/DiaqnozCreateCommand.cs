using CleanArchitecture.Domain.Modules.Admin.Diaqnozs;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Diaqnozs
{
    public sealed record DiaqnozCreateCommand(
        string Kod,
        string Aciqlama,
        bool IsDeleted
    ) : IRequest<Result<DiaqnozGetAllQueryResponse>>;

    public sealed class DiaqnozCreateCommandValidator : AbstractValidator<DiaqnozCreateCommand>
    {
        public DiaqnozCreateCommandValidator()
        {
            RuleFor(x => x.Kod).NotEmpty().WithMessage("Kod boş ola bilməz");
            RuleFor(x => x.Aciqlama).NotEmpty().WithMessage("Açıqlama boş ola bilməz");
        }
    }

    public sealed class DiaqnozCreateCommandHandler
        (IDiaqnozRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<DiaqnozCreateCommand, Result<DiaqnozGetAllQueryResponse>>
    {
        public async Task<Result<DiaqnozGetAllQueryResponse>> Handle(DiaqnozCreateCommand request, CancellationToken cancellationToken)
        {
            var exists = await repository.AnyAsync(x => x.Kod == request.Kod, cancellationToken);
            if (exists)
            {
                return Result<DiaqnozGetAllQueryResponse>.Failure("Bu kodla diaqnoz artıq mövcuddur.");
            }
            Diaqnoz entity = request.Adapt<Diaqnoz>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new DiaqnozGetAllQueryResponse
            {
                Id = entity.Id,
                Kod = entity.Kod,
                Aciqlama = entity.Aciqlama,
                IsDeleted = entity.IsDeleted,
                CreateUserName = entity.CreateUser != null ? entity.CreateUser.UserName : "none",
                CreatedDate = entity.CreatedDate,
                UpdateUserName = entity.UpdateUser != null ? entity.UpdateUser.UserName : "none",
                UpdatedDate = entity.UpdatedDate,
                DeletedUserName = entity.DeleteUser != null ? entity.DeleteUser.UserName : "none",
                DeletedDate = entity.DeletedDate
            };

            return response;
        }
    }
}
