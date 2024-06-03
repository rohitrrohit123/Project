namespace SampleProject
{
    internal class RecordSample
    {
        public static void SampleFunction()
        {
            Record1 r1a = new Record1("D S", "Rohit");

            //See we cannot edit or modify once the properites are set
            //r1a.FirstName = "D.S";

            Record1 r1b = new Record1("D S", "Rohit");
            Record1 r1c = new Record1("Sujeet", "Shinde");

            Class1 c1a = new Class1("D S", "Rohit");
            Class1 c1b = new Class1("D S", "Rohit");
            Class1 c1c = new Class1("Sujeet", "Shinde");


            /*
             * It Overrides the ToString() method which is there in every class
             * means if we directly print a Class object and Record instance just look at the difference
             */

            Console.WriteLine("Record Type :");
            Console.WriteLine("Instance : " + r1a);

            Console.WriteLine("***********************");

            Console.WriteLine("Class Type :");
            //Class will just return the Namespace.ClassName as it has not properly overriden the ToString()
            Console.WriteLine("Instance :" + c1a);


            //Implement Equals and == and ReferenceEquals and understand the difference
            // Implement GetHashCode and unserstand the difference

            //Descontruct the object - for similar descontruction in Class, we need to implement that 
            var (fn, ln) = r1a;



            Console.ReadLine();
        }

        public void EasyPrintForRecord()
        {
            
        }
    }

    /*
     * LOOK AT THE DIFFERENCE - while Defining a Record and Defining SIMILAR CLASS 
     * For a Class which does the same thing it requires more lines of Code
     */

    /*
     * Record is just a Fancy Class - The Properties cannot be Changes 
     * Means it is IMMUTABLE - Once Initialized the Values cannot be Changed
     */

    

    public record Record1(string FirstName, string LastName);

    public class Class1
    {
        //This means that the value can be changed inside the class but at any time
        public string FirstName { get; private set; }

        //This means that the value can only be changed in the Constructor / when the class is Initialized
        public string LastName { get; init; }

        public Class1(string firstName , string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
