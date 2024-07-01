internal class Program
{
    private static void Main(string[] args)
    {
        // Saisie de l'utilisateur
        int n = GetUserInputN();

        List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> integersLowerThanN = integers.FindAll(x => x <= n);

        if(integersLowerThanN.Count  > 0)
        {
            // Calcule de la moyenne
            double averageOfIntegersLowerThanN = integersLowerThanN.Average();

            // Affichage de la liste de base
            DisplayListOfInt(integers, "integers");
            // Affichage de la liste des entiers inférieurs à n
            DisplayListOfInt(integersLowerThanN, "integersLowerThanN");
            // Affichage de la moyenne de la liste des entiers inférieurs à n
            Console.WriteLine($"La moyenne des de la liste des entiers inférieurs à {n} : {averageOfIntegersLowerThanN}");
        }
        else
        {
            Console.WriteLine("La moyenne ne peut pas être calculée.");
        }
    }

    public static void DisplayListOfInt(List<int> integers, string variableName)
    {
        Console.Write(variableName + " {");

        foreach (int s in integers)
        {
            if(integers.Last() == s)
            {
                Console.WriteLine(s + "}");
            }
            else
            {
                Console.Write($"{s}, ");
            }
        }
    }

    public static int GetUserInputN()
    {
        bool isValid = false;
        int n = 0;
        string userInput;

        while (!isValid)
        {
            Console.Write("Entres la valeur de n : ");
            userInput = Console.ReadLine();

            isValid = int.TryParse(userInput, out n);

            if (!isValid)
            {
                Console.WriteLine($"Tu dois entrer un entier compris entre {Int32.MinValue} et {Int32.MaxValue} \n");
            }
        }

        return n;
    }
}