namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatard { get; set; }
        public Adress Adress { get; set; }

    }
}
