using CleanArchitecture.Domain.Modules.Accounts.Users;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Accounts.Passwords
{
    public sealed record ChangePasswordCommand(
        int UserId,
        string CurrentPassword,
        string NewPassword
        ) : IRequest<Result<string>>;

    public sealed class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
    {
        public ChangePasswordCommandValidator()
        {
            RuleFor(x => x.UserId)
                .GreaterThan(0)
                .WithMessage("İstifadəçi seçilməyib");

            RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage("Yeni şifrə təkrarı boş ola bilməz")
                .MinimumLength(8)
                .WithMessage("Şifrə təkrarı minimum 8 simvol olmalıdır")
                .MaximumLength(25)
                .WithMessage("Şifrə təkrarı maksimum 25 simvol olmalıdır");

            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage("Yeni şifrə boş ola bilməz")
                .MinimumLength(8)
                .WithMessage("Şifrə minimum 8 simvol olmalıdır")
                .MaximumLength(25)
                .WithMessage("Şifrə maksimum 25 simvol olmalıdır");
        }
    }

    internal sealed class ChangePasswordCommandHandler
        (UserManager<AppUser> userManager) : IRequestHandler<ChangePasswordCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if(user is null)
            {
                return Result<string>.Failure("İstidaəçi məlumatları tapılmadı");
            }

            var result = await userManager.ChangePasswordAsync(
                user,
                request.CurrentPassword,
                request.NewPassword
            );

            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(x => x.Description));
                return Result<string>.Failure(errors);
            }

            return "Şifrə uğurla dəyişidirildi";
        }
    }
}
