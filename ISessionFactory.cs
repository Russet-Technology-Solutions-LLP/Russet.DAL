namespace Russet.DAL
{
    public interface ISessionFactory
    {
        ///<summary>
        /// Gets the current UoW.
        /// </summary>
        /// <value>The current UoW.</value>
        IUnitOfWork CurrentUoW { get; }
    }
}
