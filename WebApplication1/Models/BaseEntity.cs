namespace WebApplication1.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }

        public DateTime CreateTime { get; set; }

    }
}
