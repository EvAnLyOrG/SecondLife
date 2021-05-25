namespace SecondLife.Model.Entities
{
    public class AnnonceRating
    {
        public int Id { get; set; }
        public Annonce Annonce { get; set; }
        public User User { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }
    }
}
