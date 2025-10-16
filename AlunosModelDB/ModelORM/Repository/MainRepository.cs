
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ModelORM.Infrastructure;
using MySqlConnector;

namespace ModelORM.Repository
{
    public class MainRepository<T> : IMainRepositoy<T> where T : class
    {
        protected readonly AppDbContext context;
        public MainRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<T> Create(T entity)
        {
            try
            {
                this.context.Set<T>().Add(entity);
                await this.context.SaveChangesAsync();
                return entity;
            }
            catch (MySqlException mx)
            {
                throw new Exception(mx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> Delete(long id)
        {
            try
            {
                T? idFind = this.context.Set<T>().Find(id) ??
                    throw new Exception("Registro não encotrado");
                this.context.Set<T>().Remove(idFind);
                await this.context.SaveChangesAsync();
                return idFind;
            }
            catch (MySqlException mx)
            {
                throw new Exception(mx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                List<T> result = await this.context.Set<T>().ToListAsync();
                return result;
            }
            catch (MySqlException mx)
            {
                throw new Exception(mx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> GetById(long id)
        {
            try
            {
                T result = await this.context.Set<T>().FindAsync(id) ??
                    throw new KeyNotFoundException("Registro não encontrado"); ;

                return result;
            }
            catch (MySqlException mx)
            {
                throw new Exception(mx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> Update(T entity)
        {
            try
            {
                this.context.Set<T>().Update(entity);
                await this.context.SaveChangesAsync();
                return entity;
            }
            catch (MySqlException mx)
            {
                throw new Exception(mx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
