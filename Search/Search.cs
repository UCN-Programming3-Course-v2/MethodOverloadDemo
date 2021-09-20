using System.Collections.Generic;

namespace Search
{
    public class Search
    {
        private static List<Person> persons = new List<Person>()
        {
            new Person{Id = 1, Name = "Hans"},
            new Person{Id = 2, Name = "Knud"}
        };


        public Person Find(int? id = null, string name = null)
        {
            Person result = null;

            if (name != null)
            {
                // Search database by Name
                result = persons.Find(p => p.Name == name);
            }
            else if (id != null)
            {
                // Search database by ID
                result = persons.Find(p => p.Id == id);
            }
            return result;
        }

        //public Person Find(string name)
        //{
        //    // Search database by Name
        //    return persons.Find(p => p.Name == name);
        //}


        //private Person FindById(int id)
        //{
        //    // Search database by ID
        //    return persons.Find(p => p.Id == id);
        //}

        //private Person FindByName(string name)
        //{
        //    // Search database by Name
        //    return persons.Find(p => p.Name == name);
        //}
    }
}
