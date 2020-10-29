using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

class GreenvilleRevenue
{
    public static void Main()
    {
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        int num;
        int revenue = 0;
        const char QUIT = 'Z';
        char option = ' '; ;
        Contestant[] contestants = new Contestant[MAX_CONTESTANTS];
        num = getContestantNumber(MIN_CONTESTANTS, MAX_CONTESTANTS);
        revenue = getContestantData(num, contestants, revenue);
        Console.WriteLine("\n\nRevenue expected this year is {0}", revenue.ToString("C"));
        while (option != QUIT)
            option = getLists(num, contestants);

        Stream fileStream = new FileStream("data.txt", FileMode.Create, FileAccess.Write);
        Contestant contestant = DeserializeContestant(fileStream);

    }

    private static void SerializeContestant(Contestant contestants, Stream fileStream)
    {
        using (fileStream)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, contestants);
                Console.WriteLine("Serialization is successfull!!!");
            }
            catch(FileNotFoundException caught)
            {
                Console.WriteLine(string.Format("The message {0}, the source {1}", caught.Message, caught.Source.ToString()));
            }

        }
    }

    private static Contestant DeserializeContestant(Stream fileStream)
    {
        Contestant contestants;
        using (fileStream)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                contestants = binaryFormatter.Deserialize(fileStream) as Contestant;
                Console.WriteLine("Serialization is successfull!!!");
                return contestants;
            }
            catch (FileNotFoundException caught)
            {
                Console.WriteLine(string.Format("The message {0}, the source {1}", caught.Message, caught.Source.ToString()));
                return null;
            }

        }
    }

private static int getContestantNumber(int min, int max)
    {
        string entryString;
        int num = max + 1;
        Console.Write("Enter number of contestants >> ");
        entryString = Console.ReadLine();
        while (num < min || num > max)
        {
            if (!int.TryParse(entryString, out num))
            {
                Console.WriteLine("Format invalid");
                num = max + 1;
                Console.Write("Enter number of contestants >> ");
                entryString = Console.ReadLine();
            }
            else
            {
                try
                {
                    if (num < min || num > max)
                        throw (new ArgumentException());
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Number must be between {0} and {1}", min, max);
                    num = max + 1;
                    Console.Write("Enter number of contestants >> ");
                    entryString = Console.ReadLine();
                }
            }
        }
        return num;
    }
    
    private static int getContestantData(int num, Contestant[] contestants, int revenue)
    {
        const int ADULTAGE = 17;
        const int TEENAGE = 12;
        int x = 0;
        string name;
        char talent;
        int age;
        int pos;
        while (x < num)
        {
            Console.Write("Enter contestant name >> ");
            name = Console.ReadLine();
            Console.WriteLine("Talent codes are:");
            for (int y = 0; y < Contestant.talentCodes.Length; ++y)
                Console.WriteLine("  {0}   {1}", Contestant.talentCodes[y], Contestant.talentStrings[y]);
            Console.Write("       Enter talent code >> ");
            char.TryParse(Console.ReadLine(), out talent);
            try
            {
                validateCode(talent, out pos);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} is not a valid code. Assigned as Invalid.", talent);
            }
            Console.Write("       Enter contestant's age >> ");
            int.TryParse(Console.ReadLine(), out age);
            if (age > ADULTAGE)
                contestants[x] = new AdultContestant();
            else
               if (age > TEENAGE)
                contestants[x] = new TeenContestant();
            else
                contestants[x] = new ChildContestant();
            contestants[x].Name = name;
            contestants[x].TalentCode = talent;
            revenue += contestants[x].Fee;
            ++x;
        }
        return revenue;

       
    }
    
    
    private static char getLists(int num, Contestant[] contestants)
    {
        int x;
        char QUIT = 'Z';
        char option = ' ';
        bool isValid;
        int pos = 0;
        bool found;
        Console.WriteLine("\nThe types of talent are:");
        for (x = 0; x < Contestant.talentStrings.Length; ++x)
            Console.WriteLine("{0, -6}{1, -20}", Contestant.talentCodes[x], Contestant.talentStrings[x]);
        Console.Write("\nEnter a talent type or {0} to quit >> ", QUIT);
        isValid = false;
        while (!isValid)
        {
            if (!char.TryParse(Console.ReadLine(), out option))
            {
                isValid = false;

                Console.WriteLine("Invalid format - entry must be a single character");
                Console.Write("\nEnter a talent type or {0} to quit >> ", QUIT);
            }
            else
            {
                if (option == QUIT)
                    isValid = true;
                else
                {
                    try
                    {
                        validateCode(option, out pos);
                        isValid = true;
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("{0} is not a valid code", option);
                        Console.Write("\nEnter a talent type or {0} to quit >> ", QUIT);
                        isValid = false;
                    }
                }
                if (isValid && option != QUIT)
                {

                    Console.WriteLine("\nContestants with talent {0} are:", Contestant.talentStrings[pos]);
                    found = false;
                    for (x = 0; x < num; ++x)
                    {
                        if (contestants[x].TalentCode == option)
                        {
                            Console.WriteLine(contestants[x].ToString());
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("No contestants had talent {0}", Contestant.talentStrings[pos]);
                        isValid = false;
                        Console.Write("\nEnter a talent type or {0} to quit >> ", QUIT);
                    }
                }
            }
        }
        return option;


    }
    public static void validateCode(char option, out int pos)
    {
        bool isValid = false;
        pos = Contestant.talentCodes.Length - 1;
        for (int z = 0; z < Contestant.talentCodes.Length; ++z)
        {
            if (option == Contestant.talentCodes[z])
            {
                isValid = true;
                pos = z;
            }
        }
        if (!isValid)
            throw (new ArgumentException());
    }

}

class Contestant
{
    public static char[] talentCodes = { 'S', 'D', 'M', 'O' };
    public static string[] talentStrings = {"Singing", "Dancing",
           "Musical instrument", "Other"};
    public string Name { get; set; }
    private char talentCode;
    private string talent;
    private int fee;
    public char TalentCode
    {
        get
        {
            return talentCode;
        }
        set
        {
            int pos = talentCodes.Length;
            for (int x = 0; x < talentCodes.Length; ++x)
                if (value == talentCodes[x])
                    pos = x;
            if (pos == talentCodes.Length)
            {
                talentCode = 'I';
                talent = "Invalid";
            }
            else
            {
                talentCode = value;
                talent = talentStrings[pos];
            }
        }

    }
    public string Talent
    {
        get
        {
            return talent;
        }
    }
    public int Fee
    {
        get
        {
            return fee;
        }
        set
        {
            fee = value;
        }
    }


}

class AdultContestant : Contestant
{
    public int ADULT_FEE = 30;
    public AdultContestant()
    {
        Fee = ADULT_FEE;
    }
    public override string ToString()
    {
        return ("Adult Contestant " + Name + " " + TalentCode + "   Fee " + Fee.ToString("C"));
    }

   
}

class TeenContestant : Contestant
{
    public int TEEN_FEE = 20;
    public TeenContestant()
    {
        Fee = TEEN_FEE;
    }
    public override string ToString()
    {
        return ("Teen Contestant " + Name + " " + TalentCode + "   Fee " + Fee.ToString("C"));
    }
    
}

class ChildContestant : Contestant
{
    public int CHILD_FEE = 15;
    public ChildContestant()
    {
        Fee = CHILD_FEE;
    }
    public override string ToString()
    {
        return ("Child Contestant " + Name + " " + TalentCode + "   Fee " + Fee.ToString("C"));
    }
   
}
