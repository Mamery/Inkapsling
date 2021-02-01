using System;

namespace Inkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				PersonHandler persHandler = new PersonHandler();
				Person p = persHandler.CreatePerson(23, "Mike", "Sanoh", 1.80, 85.5);
				Console.WriteLine(p.ToString());
				Console.WriteLine("Change Mike age to 45");
				persHandler.SetAge(p, 45);
				Console.WriteLine(p.ToString());
				Console.WriteLine(p.Age);

				Person p1 = persHandler.CreatePerson(35, "Jeorges", "Weah", 1.80, 85.5);
				Console.WriteLine(p1.ToString());
				Person p2 = persHandler.CreatePerson(27, "Bamba", "Lamine", 1.80, 85.5);
				Console.WriteLine("Set Bamba age to zero");
				persHandler.SetAge(p2, 2);
                //Check validation on forname
				Person p3 = persHandler.CreatePerson(27, "Ba", "Lamine", 1.80, 85.5);
				Console.WriteLine(p3.FName);

			}
			catch (Exception e)
			{
			Console.WriteLine(e.Message);
			}
        }
    }
}
