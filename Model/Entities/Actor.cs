namespace backendReactFinal.Model.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string FullName { get; set; }    
        public string PictureUrl { get; set; }

        public ICollection<MovieActor> MovieActor { get; set; }

    }
}
