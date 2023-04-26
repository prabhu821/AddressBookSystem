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
                PhoneNumber = "86565434476"
            };
            AddressBookRepository repository = new AddressBookRepository();
            int result = repository.UpdatePresoninAddressBook(model);
            Assert.AreEqual(1, result);
        }
    }
}