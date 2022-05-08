namespace MVC_08.Models
{

    public static class PersonRepository
    {
        public static List<Person> Persons = new();
        static PersonRepository()
        {
            Persons.Add(new Person() { Id = 1, Name = "Mohammad Hosein" });
            Persons.Add(new Person() { Id = 2, Name = "Mohammad Ali" });
            Persons.Add(new Person() { Id = 3, Name = "Zahra" });
            Persons.Add(new Person() { Id = 4, Name = "Amir Mohammad" });
            Persons.Add(new Person() { Id = 5, Name = "Amin" });

        }

        public static List<Person> GetAll()
        {
            return Persons;
        }


        public static void Delete(int Id)
        {
            var person = Persons.FirstOrDefault(w => w.Id == Id);
            Persons.Remove(person);
        }
        public static Person Finder(int Id)
        {
            var person = Persons.FirstOrDefault((s) => s.Id == Id);
            return person;
        }
       

    }
}

