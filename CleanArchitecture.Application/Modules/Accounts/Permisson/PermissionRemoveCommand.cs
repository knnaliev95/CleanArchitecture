using FluentValidation;
using GenericRepository;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Accounts.Permisson
{
    public sealed record PermissionRemoveCommand(
        string Name
        ) : IRequest<Result<string>>;

    public sealed class PermissionRemoveCommandValidator : AbstractValidator<PermissionRemoveCommand>
    {
        public PermissionRemoveCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Silinəcək səlahiyyət adı boş ola bilməz");
        }
    }

    public sealed class PermissionRemoveCommandHandler
        (RoleManager<IdentityRole<int>> roleManager, IUnitOfWork unitOfWork) : IRequestHandler<PermissionRemoveCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(PermissionRemoveCommand request, CancellationToken cancellationToken)
        {
            var exist = await roleManager.FindByNameAsync(request.Name);

            if (exist is null)
            {
                return Result<string>.Failure("Bu adda səlahiyyət mövcud deyil");
            }

            await roleManager.DeleteAsync(exist);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return ("Səlahiyyət uğurla silindi");
        }
    }
}