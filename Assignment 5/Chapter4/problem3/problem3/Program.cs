using System;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName;
            string companyAddress;
            ulong companyPhoneNumber;
            ulong companyFaxNumber;
            string companyWebSite;
            string managerName;
            string managerSurname;
            ulong managerPhoneNumber;
            Console.WriteLine("Enter the company name, address, phone number, fax number and website: ");
            companyName = Console.ReadLine();
            companyAddress = Console.ReadLine();
            companyPhoneNumber = ulong.Parse(Console.ReadLine());
            companyFaxNumber = ulong.Parse(Console.ReadLine());
            companyWebSite = Console.ReadLine();
            Console.WriteLine("Enter the manager name, surname and phone number: ");
            managerName = Console.ReadLine();
            managerSurname = Console.ReadLine();
            managerPhoneNumber = ulong.Parse(Console.ReadLine());
            Console.WriteLine($"Company Name: {companyName} Company Address: {companyAddress} Company Phone Number: {companyPhoneNumber} " +
                $"Company Fax Number: {companyFaxNumber} Company Website: {companyWebSite} Company Manager Name: {managerName} " +
                $"Manager Surname: {managerSurname} Manager Phone Number: {managerPhoneNumber}");
        }
    }
}
