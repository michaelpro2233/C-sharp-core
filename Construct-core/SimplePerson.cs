using System;

namespace Examples.Constructcore
{
    class SimplePerson
    {
        private readonly string personName;
        public int PersonAge;

        public SimplePerson()
        {
        }

        public SimplePerson(string name, int age)
        {
            personName = name;
            PersonAge = age;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, PersonAge);
        }
    }
}