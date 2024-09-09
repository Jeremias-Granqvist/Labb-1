//29535123p48723487597645723645 teststräng

using System.Diagnostics;
Console.Write("Vänligen skriv in din sträng med siffror och bokstäver.");
string userString = Console.ReadLine();
Int128 result = 0;
char firstChar;

for (int i = 0; i < userString.Length; i++)
{
    firstChar = userString[i];

    for (int j = i + 1; j < userString.Length; j++)
    {

        char jChar = userString[j];

        if (firstChar == userString[j])
        {
            int parseLength = Math.Abs(i - j);
            string userSubString = userString.Substring(i, parseLength + 1);
            Int128 middleNum;
            bool parseString = Int128.TryParse(userSubString, out middleNum);
            result = middleNum + result;
            if (parseString == true)
            {
                Debug.WriteLine(middleNum);
                for (int k = 0; k < userString.Length; k++)
                {
                    if (k >= i || k <= j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (k < i || k > j)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(userString[k]);
                }

                Console.ResetColor();
                Console.WriteLine();
                break;
            }
            else if (parseString == false)
            {
                continue;
            }

        }
        else
        {
            continue;
        }
    }

}

Console.WriteLine();
Console.WriteLine(result);
