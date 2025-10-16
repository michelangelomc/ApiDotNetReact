using ModelORM.Models;
using ModelORM.Repository.UnitOfWork;

namespace Infrastructure.DataProvider.Servives.DataBaseServices
{
    public class AlunoDbService : IAlunoDbService
    {
        private readonly IUnitOfWork unitOfWork;

        public AlunoDbService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<AlunoModel> Create(AlunoModel entity)
        {
            return await this.unitOfWork.AlunoRepository.Create(entity);
        }

        public async Task<AlunoModel> Delete(long id)
        {
            return await this.unitOfWork.AlunoRepository.Delete(id);
        }

        public Task<List<AlunoModel>> GetAll()
        {
            return this.unitOfWork.AlunoRepository.GetAll();
        }

        public async Task<AlunoModel> GetById(long id)
        {
            return await this.unitOfWork.AlunoRepository.GetById(id);
        }

        public async Task<AlunoModel> Update(AlunoModel entity)
        {
            return await this.unitOfWork.AlunoRepository.Update(entity);
        }
    }
}