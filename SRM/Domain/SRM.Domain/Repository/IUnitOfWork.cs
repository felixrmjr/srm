namespace SRM.Domain.Repository
{
    public interface IUnitOfWork<TContext>
    {
        int Commit();
    }
}