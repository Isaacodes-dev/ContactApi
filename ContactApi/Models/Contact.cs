namespace ContactApi.Models
{
    public class Contact
    {
        public Guid Id { get; set; }

        public string Fullname { get; set; }
        public string Email { get; set; }

        public long phone { get; set; }
        public string Address { get; set; }
    }
}
