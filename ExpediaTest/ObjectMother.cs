using Expedia;
using System;

namespace ExpediaTest
{
	public class ObjectMother
	{
        public static Car Saab()
        {
            return new Car(7){ Name = "Saab 9-58 Sports Sedan" };
        }

        public static Car BMW()
        {
            return new Car(10) { Name = "BMW Z4 Roadster" };
        }
	}
}
