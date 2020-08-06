using System;
using System.Collections.Generic;
using System.Text;

namespace XMLReaderApp
{
    public class Person
    {
        private string _name = string.Empty;
        private string _surname = string.Empty;
        private int _age = 0;

        public Person()
        {
        }

        public Person(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int Age { get => _age; set => _age = value; }

        public override string ToString()
        {
            return $"Name: {_name} \nSurname: {_surname} \nAge: {_age} \n";
        }
    }
}
