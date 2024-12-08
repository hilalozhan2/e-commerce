namespace guitars.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //relationships
        public List<Product> Products { get; set; }
    }
}
