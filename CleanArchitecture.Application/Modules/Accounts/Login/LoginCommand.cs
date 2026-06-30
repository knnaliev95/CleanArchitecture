using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Accounts.Login
{
    public sealed record LoginCommand(
        string Username, string Password
        ) : IRequest<Result<LoginCommandResponse>>;

    public sealed record LoginCommandResponse
    {
        public string Token { get; set; } = default!;
    }

    internal sealed class LoginCommandHandler(
        UserManager<AppUser> userManager,
        SignInManager<AppUser> signInManager,
        IJwtProvider jwtProvider
        ) : IRequestHandler<LoginCommand, Result<LoginCommandResponse>>
    {
        public async Task<Result<LoginCommandResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser? user = await userManager.Users.FirstOrDefaultAsync(u => u.UserName == request.Username, cancellationToken);

            if (user is null)
            {
                return Result<LoginCommandResponse>.Failure("İstifdaçi adı tapılmadı.");
            }

            SignInResult signInResult = await signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (!signInResult.Succeeded)
            {
                return Result<LoginCommandResponse>.Failure("Şifrə yanlış");
            }

            var token = await jwtProvider.CreateTokenAsync(user, request.Password, cancellationToken);

            var response = new LoginCommandResponse
            {
                Token = token
            };

            return response;
        }
    }
}
