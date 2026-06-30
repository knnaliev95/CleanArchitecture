using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.MuracietSebebis
{
    public sealed record MuracietSebebiGetAllQuery() : IRequest<IQueryable<MuracietSebebiGetAllQueryResponse>>;

    public sealed class MuracietSebebiGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = string.Empty;
    }

    internal sealed class MuracietSebebiGetAllQueryHandler
        (IMuracietSebebiRepository repository) : IRequestHandler<MuracietSebebiGetAllQuery, IQueryable<MuracietSebebiGetAllQueryResponse>>
    {
        public Task<IQueryable<MuracietSebebiGetAllQueryResponse>> Handle(MuracietSebebiGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from m in repository.GetAll()
                            select new MuracietSebebiGetAllQueryResponse
                            {
                                Id = m.Id,
                                Ad = m.Ad,
                                IsDeleted = m.IsDeleted,
                                CreateUserName = m.CreateUser != null ? m.CreateUser.UserName : "none",
                                CreatedDate = m.CreatedDate,
                                UpdateUserName = m.UpdateUser != null ? m.UpdateUser.UserName : "none",
                                UpdatedDate = m.UpdatedDate,
                                DeletedUserName = m.DeleteUser != null ? m.DeleteUser.UserName : "none",
                                DeletedDate = m.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
