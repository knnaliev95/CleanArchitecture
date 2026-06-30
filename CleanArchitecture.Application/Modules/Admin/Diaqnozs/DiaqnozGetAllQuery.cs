using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Diaqnozs;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Diaqnozs
{
    public sealed record DiaqnozGetAllQuery() : IRequest<IQueryable<DiaqnozGetAllQueryResponse>>;

    public sealed class DiaqnozGetAllQueryResponse : BaseEntityDto
    {
        public string Kod { get; set; } = string.Empty;
        public string Aciqlama { get; set; } = string.Empty;
    }

    internal sealed class DiaqnozGetAllQueryHandler
        (IDiaqnozRepository diaqnozRepository) : IRequestHandler<DiaqnozGetAllQuery, IQueryable<DiaqnozGetAllQueryResponse>>
    {
        public Task<IQueryable<DiaqnozGetAllQueryResponse>> Handle(DiaqnozGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from d in diaqnozRepository.GetAll()
                            select new DiaqnozGetAllQueryResponse
                            {
                                Id = d.Id,
                                Kod = d.Kod,
                                Aciqlama = d.Aciqlama,
                                IsDeleted = d.IsDeleted,
                                CreateUserName = d.CreateUser != null ? d.CreateUser.UserName : "none",
                                CreatedDate = d.CreatedDate,
                                UpdateUserName = d.UpdateUser != null ? d.UpdateUser.UserName : "none",
                                UpdatedDate = d.UpdatedDate,
                                DeletedUserName = d.DeleteUser != null ? d.DeleteUser.UserName : "none",
                                DeletedDate = d.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
