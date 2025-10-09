
namespace ModelORM.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAlunoRepositroy AlunoRepository { get; }

        Task Commit();
        Task Rollback();
        Task Dispose();
    }
}
