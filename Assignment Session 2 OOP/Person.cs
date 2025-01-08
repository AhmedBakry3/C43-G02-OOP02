namespace Assignment_Session_2_OOP
{
    internal struct Person
    {
        #region Attributes
        public string? Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Person(string? name , int age)  { 
           Name = name;
           Age = age;  
        }
        #endregion

        #region Methods
        public override string ToString() //override the tostring() method
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public static Person FindOldestPerson(Person[] persons)  //Method to find the oldest person of 3 inputs
        {
            Person oldest = persons[0];
            foreach (var person in persons)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            return oldest;
        }
        #endregion
    }
}
