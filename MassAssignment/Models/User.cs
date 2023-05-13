namespace MassAssignment.Models
{
    public class User
    {
        public int ID { get; private set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public float CreditBalance { get; set; }
    }
}
