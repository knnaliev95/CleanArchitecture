using CleanArchitecture.Domain.Modules.Admin.Diaqnozs;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Diaqnozs
{
    public sealed record DiaqnozUpdateCommand(
        int Id,
        string Kod,
        string Aciqlama
    ) : IRequest<Result<DiaqnozGetAllQueryResponse>>;

    public sealed class DiaqnozUpdateCommandValidator : AbstractValidator<DiaqnozUpdateCommand>
    {
        public DiaqnozUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id düzgün deyil");
            RuleFor(x => x.Kod).NotEmpty();
            RuleFor(x => x.Aciqlama).NotEmpty();
        }
    }

    internal sealed class DiaqnozUpdateCommandHandler
        (IDiaqnozRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<DiaqnozUpdateCommand, Result<DiaqnozGetAllQueryResponse>>
    {
        public async Task<Result<DiaqnozGetAllQueryResponse>> Handle(DiaqnozUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<DiaqnozGetAllQueryResponse>.Failure("Diaqnoz tapılmadı");

            var exists = await repository.AnyAsync(x => x.Kod == request.Kod && x.Id != request.Id, cancellationToken);
            if (exists) return Result<DiaqnozGetAllQueryResponse>.Failure("Bu kodla başqa diaqnoz mövcuddur");

            request.Adapt(entity);

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
