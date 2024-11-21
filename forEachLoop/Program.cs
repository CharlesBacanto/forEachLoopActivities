class Program
{
    static void Main(string[] args)
    {   
        //Each names in an array
        string[] userNames = { "Giyu", "Tanjiro", "Nezuko", "Inosuke", "Zenitsu" };
        string findName = "Bacanto";
        foreach(string name in userNames)
        {
            if (name.Equals(findName))
            {
                Console.WriteLine(name+" is found");
                break;
            }
            else
            {
                Console.WriteLine("Name not found");
            }
           
        }


        //Each Letter in a Word
        int charcount = 0;
        string word = Console.ReadLine();
        char letter = Convert.ToChar(Console.ReadLine());
        foreach(char c in word)
        {
            if(c.Equals(letter))
            {
                charcount++;
            }
        }
        Console.WriteLine(charcount);

        

       
    }
}