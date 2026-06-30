using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Sobeler
{
    public sealed record SobeGetAllQuery() : IRequest<IQueryable<SobeGetAllQueryResponse>>;

    public sealed class SobeGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = default!;
        public bool? IsAmbulator { get; set; }
        public bool? IsStasionar { get; set; }
    }

    internal sealed class SobeGetAllQueryHandler(ISobeRepository SobeRepository) : IRequestHandler<SobeGetAllQuery, IQueryable<SobeGetAllQueryResponse>>
    {
        public Task<IQueryable<SobeGetAllQueryResponse>> Handle(SobeGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from Sobe in SobeRepository.GetAll()
                            select new SobeGetAllQueryResponse
                            {
                                Id = Sobe.Id,
                                Ad = Sobe.Ad,
                                IsAmbulator = Sobe.IsAmbulator,
                                IsStasionar = Sobe.IsStasionar,
                                IsDeleted = Sobe.IsDeleted,
                                CreateUserName = Sobe.CreateUser != null ? Sobe.CreateUser.UserName : "none",
                                CreatedDate = Sobe.CreatedDate,
                                UpdateUserName = Sobe.UpdateUser != null ? Sobe.UpdateUser.UserName : "none",
                                UpdatedDate = Sobe.UpdatedDate,
                                DeletedUserName = Sobe.DeleteUser != null ? Sobe.DeleteUser.UserName : "none",
                                DeletedDate = Sobe.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
