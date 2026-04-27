namespace src.ObserverDesignPattern.Models
{
    public class User
    {
        public string Name{get; set;}

        public string Email {get; set;}

        public int Number{get; set;}

        public User(string name, string email, int number)
        {
            this.Name = name;
            this.Email = email;
            this.Number = number;
        }
    }
}