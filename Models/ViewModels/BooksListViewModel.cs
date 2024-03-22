namespace mission11_Sara.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Book> Books { get; set; }

        public Pagination Pagination { get; set; } = new Pagination();

    }
}
