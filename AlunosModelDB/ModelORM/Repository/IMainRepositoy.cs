namespace ModelORM.Repository
{
    public interface IMainRepositoy<T>
    {
        Task<T> GetById(Int64 id);
        Task<T> Create(T entity);
        Task<T> Delete(Int64 id);
        Task<T> Update(T entity);
        Task<List<T>> GetAll();
    }
}