namespace ContactApi.Models
{
    public class UpdateContactRequest
    {
        public string Fullname { get; set; }
        public string Email { get; set; }

        public long phone { get; set; }
        public string Address { get; set; }
    }
}
