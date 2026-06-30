using CleanArchitecture.Domain.Modules.Accounts.Users;
using FluentValidation;
using GenericRepository;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Accounts.Passwords
{
    public sealed record ResetPasswordCommand(
        int UserId,
        string NewPassword,
        string RepeatPassword
        ) : IRequest<Result<string>>;

    public sealed class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand>
    {
        public ResetPasswordCommandValidator()
        {
            RuleFor(x => x.UserId)
                .GreaterThan(0)
                .WithMessage("İstifadəçi seçilməyib");

            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage("Yeni şifrə boş ola bilməz")
                .MinimumLength(8)
                .WithMessage("Şifrə minimum 8 simvol olmalıdır")
                .MaximumLength(25)
                .WithMessage("Şifrə maksimum 25 simvol olmalıdır");

            RuleFor(x => x.RepeatPassword)
                .NotEmpty()
                .WithMessage("Yeni şifrə təkrarı boş ola bilməz")
                .MinimumLength(8)
                .WithMessage("Şifrə təkrarı minimum 8 simvol olmalıdır")
                .MaximumLength(25)
                .WithMessage("Şifrə təkrarı maksimum 25 simvol olmalıdır");
        }
    }

    internal sealed class ResetPasswordCommandHandler
        (UserManager<AppUser> userManager, IUnitOfWork unitOfWork) : IRequestHandler<ResetPasswordCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            if(request.NewPassword != request.RepeatPassword)
            {
                return Result<string>.Failure("Yeni şifrə və şifrə təkrarı eyni olmalıdır");
            }

            var user = await userManager.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if(user is null)
            {
                return Result<string>.Failure("İstifadəçi məlumatları tapılmadı");
            }

            var token = await userManager.GeneratePasswordResetTokenAsync(user);

            await userManager.ResetPasswordAsync(user, token, request.NewPassword);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Şifrə uğurla yeniləndi";
        }
    }
}
