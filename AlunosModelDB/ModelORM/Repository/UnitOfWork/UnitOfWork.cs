using ModelORM.Infrastructure;

namespace ModelORM.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public IAlunoRepositroy? alunoRepository;
        protected AppDbContext context;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }


        public IAlunoRepositroy AlunoRepository
        {
            get
            {
                return alunoRepository = alunoRepository ?? new AlunoRepository(context);
            }
        }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public async Task Dispose()
        {
            await context.DisposeAsync();
        }

        public async Task Rollback()
        {
            await context.Database.RollbackTransactionAsync();
        }
    }
}
