
using System;
using System.Collections;
using System.IO;

class card
{
    private string name;
    private int value;
    private string nameOfAttack;
    public card(string name, int value, string nameOfAttack)
    {
        this.name = name;
        this.value = value;
        this.nameOfAttack = nameOfAttack;
    }

    public override string ToString()
    {
        string returnedString = string.Format("Name: " + name + "\nDamage %: " + value + "\nAttack Name " + nameOfAttack);

        return returnedString;
    }

    public static void Main(String[] args)
    {

        ArrayList cards = new ArrayList();
        ArrayList fileLines = new ArrayList();

        try
        {
            StreamReader inFile = new StreamReader("cards.txt");

            

            for (int i = 0; i < fileLines.Count; i++)
            {
                Console.WriteLine("{0} : {1}", i, fileLines[i]);
            }

            /*for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i].ToString());
            }*/

        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Error with file!");
            Console.WriteLine(e.ToString());
        }


    }
}