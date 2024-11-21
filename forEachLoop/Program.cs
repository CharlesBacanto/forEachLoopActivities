class Program
{
    static void Main(string[] args)
    {   
        //Each names in an array
        string[] userNames = { "Giyu", "Tanjiro", "Nezuko", "Inosuke", "Zenitsu" }; // Array of userNames
        Console.Write("Please enter a name to find: ");// Prompt the user a name to be found
        string findName = Console.ReadLine(); //Fetch the name
        
        foreach(string name in userNames)
        {
            if (name.Equals(findName)) //If the given name is found print out a message
            {
                Console.WriteLine(name+" is found");
                break;
            }
            
        }


        //Each Letter in a Word
        int charcount = 0; // Initial Char Count
        Console.Write("Please enter a word to be counted with: ");// Prompt the user to enter a word to be counted with
        string word = Console.ReadLine(); // Fetch the word
        Console.Write("Please enter a character to be counted in the provided word: ");// Prompt the user to enter a character to count in the provided word
        char letter = Convert.ToChar(Console.ReadLine()); // Fetch the letter
        foreach (char c in word) // For each character in the word
        {
            if(c.Equals(letter)) // If the given character is found in the word increase char count
            {
                charcount++;
            }
        }
        Console.WriteLine(charcount);// Print out total of characters founded in the word

        //Array of Integers Summation
        int sum=0;// Initial Value of Total

        int[] valuesArray = { 1, 2, 3 }; // Array of Values 

        foreach(int i in valuesArray)// For Each Value in the Array it would be added to the sum
        {
            
            sum += i;

        }
        Console.WriteLine("Total: "+sum); // Print out Total
       
    }
}