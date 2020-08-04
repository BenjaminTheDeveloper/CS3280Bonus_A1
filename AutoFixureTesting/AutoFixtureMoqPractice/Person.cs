using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFixtureMoqPractice
{
    /// <summary>
    /// This person class uses an interface for its methods. It was created to allow for Mock data to be put into unit testing
    /// </summary>
    public class Person
    {

        //Using the interface 
        private readonly IPerson _person; 



        //If anything within IPerson is Null it will throw out the Person
        //Interfaced person becomes the new person object
        public Person(IPerson person)
        {
            if(person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            else
            {
                _person = person; 
            }
        }


        /// <summary>
        /// These public properties can be returned. 
        /// </summary>
        /// <returns></returns>
        public string Name() => _person.name;

        public int Health() => _person.health;

        public int Skills() => _person.skills;


    }
}
