using AddressBookSystem;

namespace AddressBookSystemTest
{
    public class Tests
    {
        [Test]
        public void ShouldRetrieveAllPerson()
        {
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPerson();
            Assert.That(count, Is.EqualTo(7));
        }

        [Test]
        public void ShouldUpdatePerson()
        {
            Contact model = new Contact
            {
                Id = 3,
                Address = "6th cross street",
                PhoneNumber = "8656543447"
            };
            AddressBookRepository repository = new AddressBookRepository();
            int result = repository.UpdatePresoninAddressBook(model);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void GetpersonbyDate()
        {
            Contact model = new Contact();
            model.DateAdded = "2023-01-17";
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPersonDate(model);
            Assert.AreEqual(1, count);
        }
        [Test]
        public void GetpersonbyCityName()
        {
            Contact model = new Contact();
            model.City = "Moradabad";
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPersonByCity(model);
            Assert.AreEqual(2, count);
        }
    }
}