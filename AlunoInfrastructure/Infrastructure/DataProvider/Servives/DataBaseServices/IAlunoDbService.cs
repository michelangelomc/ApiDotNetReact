using ModelORM.Models;

namespace Infrastructure.DataProvider.Servives.DataBaseServices
{
    public interface IAlunoDbService
    {
        Task<AlunoModel> GetById(Int64 id);
        Task<AlunoModel> Create(AlunoModel entity);
        Task<AlunoModel> Delete(Int64 id);
        Task<AlunoModel> Update(AlunoModel entity);
    }
}
