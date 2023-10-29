namespace Lab04.TH.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public string Image { get; set; } 
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public bool Status { get; set; }

        //tạo quan hệ rằng buộc - category
        public virtual Category? Category { get; set; }
    }
}
