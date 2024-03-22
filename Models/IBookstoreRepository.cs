namespace mission11_Sara.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get;}
    }
}
