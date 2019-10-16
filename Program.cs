using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class testing
    {
        static void Main(string[] args)//This Main demonstrates reference vs value based parameters
        {
            //declare and initialize various types
            int intAlpha = 0;
            int[] intArrayBeta = { 0, 1, 2 };
            string strGamma = "Hello";
            List<Person> listOfPersons = new List<Person>();
            listOfPersons.Add(new Person("John"));
            listOfPersons.Add(new Person("Bon"));
            listOfPersons.Add(new Person("Jovi"));

            
            string[] amendment = new string[10];

            amendment[0] = "Congress shall make no law respecting an establishment of religion or prohibiting the free exercise thereof, or abridging the freedom of speech or of the press, or the right of the people peaceably to assemble and to petition the government for a redress of grievances.";
            amendment[1] = "A well - regulated militia being necessary to the security of a free state, the right of the people to keep and bear arms shall not be infringed.";
            amendment[2]  = "No soldier shall, in time of peace, be quartered in any house without the consent of the owner, nor in time of war but in a manner to be prescribed by law.";
            amendment[3] = "The right of the people to be secure in their persons, houses, papers, and effects against unreasonable searches and seizures shall not be violated, and no warrants shall issue but upon probable cause, supported by oath or affirmation, and particularly describing the place to be searched and the persons or things to be seized.";
            amendment[4] = "No person shall be held to answer for a capital or otherwise infamous crime unless on a presentment or indictment of a grand jury, except in cases arising in the land or naval forces, or in the militia, when in actual service in time of war or public danger; nor shall any person be subject for the same offense to be twice put in jeopardy of life or limb; nor shall be compelled in any criminal case to be a witness against himself, nor be deprived of life, liberty, or property without due process of law; nor shall private property be taken for public use without just compensation.";
            amendment[5] = "In all criminal prosecutions, the accused shall enjoy the right to a speedy and public trial by an impartial jury of the state and district wherein the crime shall have been committed, which district shall have been previously ascertained by law, and to be informed of the nature and cause of the accusation; to be confronted with the witnesses against him; to have compulsory process for obtaining witnesses in his favor; and to have the assistance of counsel for his defense.";


            amendment[6] = "In suits at common law, where the value in controversy shall exceed twenty dollars, the right of trial by jury shall be preserved, and no fact tried by a jury shall be otherwise reexamined in any court of the United States than according to the rules of the common law.";
            amendment[7] = "Excessive bail shall not be required, nor excessive fines imposed, nor cruel and unusual punishments inflicted.";
            amendment[8] = "The enumeration in the Constitution of certain rights shall not be construed to deny or disparage others retained by the people.";
            amendment[9] = "The powers not delegated to the United States by the Constitution, nor prohibited by it to the states, are reserved to the states respectively, or to the people.";



            // Convert the 10 amendments into a string array
            // loop through the array and print each amendment
            // find the amendment that contains the word 'controversy'
            //    search_value = "controversy"
            //  int pos = amendment[3].IndexOf(amendment, search_value)
            // what is the longest amendment?

            //display before method call

            // foreach (inital to end)    { <code here> }  run for being from init to end 
            // while (condition) { <code here> }   run 0 to end 
            // do {  <code here> }  while (condition)    run 1 (once) to end


            // Console.WriteLine(amendment[1]);


            // i=0, 345
            // i=1, 240
            // i=2, 585
            // i=3, 457
            // i=4, 305

            int i = 0;
            int numLargest = 0;
            while (i < amendment.Length-1)
            {
                Console.WriteLine(amendment[i].Length);
                if (amendment[i].Length > amendment[numLargest].Length)
                {
                    numLargest = i;
                }
                i++;
            }

            Console.WriteLine("The largest string length is in "+numLargest+ "\n "+amendment[numLargest]);
            amendment[2].



            Console.WriteLine("\n\n");

            Console.WriteLine();
            Console.ReadLine();
    


        }//end Main


        //PassByVal
        private static void PassByVal(int alpha, int[] beta, string gamma, List<Person> delta)
        {


            //increase alpha and beta
            alpha++;
            for (int n = 0; n < beta.Length; n++)
            {
                beta[n]++;
            }

            //display values
            Console.WriteLine("Alpha in method PassByVal: {0}", alpha);
            Console.Write("Beta in method PassByVal: { ");

            foreach (int element in beta)
            {
                Console.Write(element + " ");
            }
            Console.Write(" }\n");

            //increase gamma and delta
            gamma = "Goodbye";
            for (int n = 0; n < delta.Count; n++)
            {
                delta[n].Name = "Newbie_" + n;
            }

            //display values
            Console.WriteLine("gamma in method PassByVal: {0}", gamma);
            Console.Write("delta in method PassByVal: ");

            foreach (Person peep in delta)
            {
                Console.Write(peep.Name + " ");
            }
            Console.WriteLine("\n\n");

            delta = new List<Person>();
            delta.Add(new Person("Michaelangelo"));
        }

        //PassByRef method
        private static void PassByRef(ref int alpha, ref int[] beta, ref string gamma, ref List<Person> delta)
        {
            //increase alpha and beta
            alpha += 3;
            for (int n = 0; n < beta.Length; n++)
            {
                beta[n] += 2;
            }

            //display values
            Console.WriteLine("Alpha in method PassByRef: {0}", alpha);
            Console.Write("Beta in method PassByRef: { ");

            foreach (int element in beta)
            {
                Console.Write(element + " ");
            }
            Console.Write(" }\n");

            //increase gamma and delta
            gamma = "Temmet Nosce";
            for (int n = 0; n < delta.Count; n++)
            {
                delta[n].Name = "Newbie_" + (n + 4);
            }

            //display values
            Console.WriteLine("gamma in method PassByRef: {0}", gamma);
            Console.Write("delta in method PassByRef: ");

            foreach (Person peep in delta)
            {
                Console.Write(peep.Name + " ");
            }
            Console.WriteLine("");

            //set equal to new
            alpha = new int();
            alpha = 5;

            //beta = new int[]();
            //beta = { 7,7,7};

            //gamma = new String("The Matrix Has You...");
            //

            delta = new List<Person>();
            delta.Add(new Person("Donatello"));


        }

    }//end class

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

    }

}
