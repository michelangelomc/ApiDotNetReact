using ModelORM.Infrastructure;
using ModelORM.Models;

namespace ModelORM.Repository
{
    public class AlunoRepository : MainRepository<AlunoModel>, IAlunoRepositroy
    {
        private readonly AppDbContext contextDb;

        public AlunoRepository(AppDbContext context) : base(context)
        {
            contextDb = context;
        }
    }
}
