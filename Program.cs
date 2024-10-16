class program
{


static void Main(string[] args)
    {
        Console.WriteLine("Type password you want to encrypt");

        string plain=Console.ReadLine();

        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plain, 13);

        bool isCorrect= BCrypt.Net.BCrypt.Verify(plain, hashedPassword);
        Console.WriteLine(hashedPassword);
        Console.WriteLine(isCorrect);

      


    }


  



} 