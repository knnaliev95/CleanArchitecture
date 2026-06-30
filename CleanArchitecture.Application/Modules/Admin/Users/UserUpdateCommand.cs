using CleanArchitecture.Domain.Modules.Accounts.Users;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Users
{
    public sealed record UserUpdateRequest(
        string Ad,
        string UserName,
        bool IsDeleted
        ) : IRequest<Result<UserGetAllQueryResponse>>;

    public sealed record UserUpdateCommand(
        int Id,
        string Ad,
        string UserName,
        bool IsDeleted
        ) : IRequest<Result<UserGetAllQueryResponse>>;

    public sealed class UserUpdateCommandValidator : AbstractValidator<UserUpdateCommand>
    {
        public UserUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id düzgün deyil.");

            RuleFor(x => x.UserName)
                .MaximumLength(50)
                .NotEmpty()
                .WithMessage("İstifadəçi adı mütləq qeyd edilməlidir");

            RuleFor(x => x.Ad)
                .MaximumLength(50)
                .NotEmpty()
                .WithMessage("Ad qeyd edilməlidir");
        }
    }

    internal sealed class UserUpdateCommandHandler
        (UserManager<AppUser> userManager, IUnitOfWork unitOfWork) : IRequestHandler<UserUpdateCommand, Result<UserGetAllQueryResponse>>
    {
        public async Task<Result<UserGetAllQueryResponse>> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.Users.FirstAsync(x => x.Id == request.Id, cancellationToken);

            if(user is null)
            {
                return Result<UserGetAllQueryResponse>.Failure("İstifadəçi tapılmadı");
            }

            request.Adapt(user);

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
