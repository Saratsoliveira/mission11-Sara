namespace mission11_Sara.Models.ViewModels
{
    public class Pagination
    {
        public int TotalItems { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalNumPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
