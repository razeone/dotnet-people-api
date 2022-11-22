namespace PeopleAPI.Models
{
    public class Person
    {
        public long Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }


        public Person(string firstName, string lastName, string email, string phone, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }
    }
}
