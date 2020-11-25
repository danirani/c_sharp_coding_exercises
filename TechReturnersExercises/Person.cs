namespace TechReturnersExercises
{
    public class Person
    {
        public string city { get; }
        public int age { get;  }

        string firstName;
        string lastName;
        
        public Person(string _firstName, string _lastName, string _city, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            city = _city;
            age = _age;
        }
    }
}