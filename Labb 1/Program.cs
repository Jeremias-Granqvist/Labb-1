//För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
//rad med hela strängen, men där delsträngen är markerad i en annan färg.


//29535123p48723487597645723645


string userString = "29535123p48723487597645723645";

char tempChar;
bool colour = false;

for (int i = 0; i < userString.Length; i++)
{
    for (int j = 1; j < userString.Length; j++)
    {
        tempChar = userString[i];

        if (tempChar == userString[j])
        {
            Console.WriteLine(userString[j]);
        }
    }

    //foreach (var number in userString)
    //{

    //    tempChar = userString[i];

    //    if (number == tempChar)
    //    {
    //        colour = !colour;
    //    }
    //    if (number == tempChar && colour)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Red;
    //    }
    //    Console.Write(number);
    //    if (number == tempChar && !colour)
    //    {
    //        Console.ForegroundColor = ConsoleColor.White;
    //    }
    //}
    Console.WriteLine();
    colour = false;
}




//Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
//sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
//Exempel output för input ”29535123p48723487597645723645”:
//Total = 5836428677242

