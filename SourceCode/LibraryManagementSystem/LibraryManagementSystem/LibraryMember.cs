namespace LibraryManagementSystem
{
    public class LibraryMember : Person
    {
        public string PhoneNo { get; set; }

        public LibraryMember(int id, string name, string phoneNo) :base (id, name)
        {
            PhoneNo = phoneNo;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Phone Number : {PhoneNo}");
        }
    }
}
