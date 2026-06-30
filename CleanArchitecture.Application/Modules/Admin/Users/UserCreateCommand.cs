using CleanArchitecture.Domain.Modules.Accounts.Users;
using FluentValidation;
using GenericRepository;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Users
{
    public sealed record UserCreateCommand(
        string Ad,
        string UserName,
        string Password,
        bool IsDeleted
        ) : IRequest<Result<UserGetAllQueryResponse>>;

    public sealed class UserCreateCommandValidator : AbstractValidator<UserCreateCommand>
    {
        public UserCreateCommandValidator()
        {
            RuleFor(x => x.UserName)
                .MaximumLength(50)
                .NotEmpty()
                .WithMessage("İstifadəçi adı mütləq qeyd edilməlidir");

            RuleFor(x => x.Ad)
                .MaximumLength(50)
                .NotEmpty()
                .WithMessage("Ad qeyd edilməlidir");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifrə mütləq qeyd edilməlidir")
                .MinimumLength(8)
                .WithMessage("Şifrə minimum 8 simvoldan ibarət olmalıdır")
                .MaximumLength(25)
                .WithMessage("Şifrə maksimum 25 simvoldan ibarət olmalıdır");
        }
    }

    public sealed class UserCreateCommandHandler
        (UserManager<AppUser> userManager, IUnitOfWork unitOfWork) : IRequestHandler<UserCreateCommand, Result<UserGetAllQueryResponse>>
    {
        public async Task<Result<UserGetAllQueryResponse>> Handle(UserCreateCommand request, CancellationToken cancellationToken)
        {
            AppUser user = new AppUser
            {
                Ad = request.Ad,
                UserName = request.UserName,
                IsDeleted = request.IsDeleted
            };

            var result = await userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                return Result<UserGetAllQueryResponse>.Failure("Xeta bas verdi");
            }

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new UserGetAllQueryResponse
            {
                Id = user.Id,
                Ad = user.Ad,
                Username = user.UserName ?? string.Empty,
                IsDeleted = user.IsDeleted,
                CreateUserName = user.CreateUser != null ? user.CreateUser.UserName : "none",
                CreatedDate = user.CreatedDate,
                UpdateUserName = user.UpdateUser != null ? user.UpdateUser.UserName : "none",
                UpdatedDate = user.UpdatedDate,
                DeletedUserName = user.DeleteUser != null ? user.DeleteUser.UserName : "none",
                DeletedDate = user.DeletedDate
            };

            return response;
        }
    }
}
