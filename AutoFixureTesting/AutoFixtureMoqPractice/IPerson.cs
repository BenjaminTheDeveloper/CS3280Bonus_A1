using System;

namespace AutoFixtureMoqPractice
{

    /// <summary>
    /// This interface is provided for the Mock Testing to mock data. 
    /// Each person should have a name, heatlh points, and an amount of skills in integer form. 
    /// </summary>
    public interface IPerson
    {
        //Every person in this has a name, health amount, and set amount of skills. 
        string name { get;  }
        int health { get;  }
        int skills { get;  }
    }
}
