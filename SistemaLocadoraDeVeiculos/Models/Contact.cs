namespace SistemaLocadoraDeVeiculos.Models
{
    public class Contact
    {
        private string Email { get; set; }
        private string? Phone { get; set; }
        public Contact(string email, string? phone)
        {
            this.Email = email;
            this.Phone = phone;
        }

        public void setPhone(string phone)
        {
            this.Phone = phone;
        }

        public override string ToString()
        {
            return $"Email: {this.Email}\nPhone: {this.Phone}";
        }
    }
}