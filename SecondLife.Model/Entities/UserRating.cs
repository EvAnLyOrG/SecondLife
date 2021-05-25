namespace SecondLife.Model.Entities
{
    public class UserRating
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }
    }
}
