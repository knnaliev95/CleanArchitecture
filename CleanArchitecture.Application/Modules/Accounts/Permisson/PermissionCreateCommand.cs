using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Accounts.Permisson
{
    public sealed record PermissionCreateCommand(
        string Name
        ) : IRequest<Result<IdentityRole<int>>>;

    public sealed class PermissionCreateCommandValidator : AbstractValidator<PermissionCreateCommand>
    {
        public PermissionCreateCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Səlahiyyət adı boş ola bilməz");
        }
    }

    public sealed class PermissionCreateCommandHandler
        (RoleManager<IdentityRole<int>> roleManager, IUnitOfWork unitOfWork) : IRequestHandler<PermissionCreateCommand, Result<IdentityRole<int>>>
    {
        public async Task<Result<IdentityRole<int>>> Handle(PermissionCreateCommand request, CancellationToken cancellationToken)
        {
            var exist = await roleManager.Roles.AnyAsync(x => x.Name == request.Name, cancellationToken);

            if (exist)
            {
                return Result<IdentityRole<int>>.Failure("Bu adda səlahiyyət mövcuddur");
            }

            IdentityRole<int> role = request.Adapt<IdentityRole<int>>();
            await roleManager.CreateAsync(role);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return role;
        }
    }
}