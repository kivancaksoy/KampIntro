using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "KIVANÇ", LastName = "AKSOY", IdentityNumber = 12345 });
        }
    }
}
