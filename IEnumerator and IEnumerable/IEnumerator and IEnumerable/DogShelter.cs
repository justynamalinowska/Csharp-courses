using System;
using System.Collections;

namespace IEnumerator_and_IEnumerable
{
	public class DogShelter : IEnumerable<Dog> //it allows to count dogs in list
	{
		public List<Dog> dogs;

		public DogShelter()
		{
			//initialize the dogs list using the collection-initializer
			dogs = new List<Dog>()
			{
				new Dog("Aga",true),
                new Dog("Brutus",false),
                new Dog("Mimi",false),
                new Dog("Boo",false),
                new Dog("Messi",true),

            };

		}

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

