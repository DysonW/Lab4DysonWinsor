Console.Clear();

Random r = new Random();
int repeat = 0;
string[] Names = new string [1000];
float[] HourlyWages = new float[1000];
double[] Yearly = new double[1000];
string[] Constanant = new string[21]{"w","b","c","d","x","f","g","h","y","j","k","l","m","n","z","p","q","r","s","t","v"};
string[] Vowel = new string[6]{"a","e","i","o","u","y"};
Console.WriteLine("Hello there, here are the 1000 people that you requested.");


for(int x = 0; x < Names.Length; x++)
{
    bool validName = false;
    string template = " ";
    while(!validName){    


        validName = true;
        decimal Decimal = (decimal)r.Next();
        float Wage = (float)r.Next(14,35);
        HourlyWages[x] = Wage;
    
        int C = r.Next(0,21);
        int B = r.Next(0,6);
        int N = r.Next(0,21);
        int K = r.Next(0,21);
        int A = r.Next(0,6);
        string Fname = Constanant[C] + Vowel[B] + Constanant[N] + Vowel[A] + Constanant[K];
        
    
        int M2 = r.Next(0,21);
        int M1 = r.Next(0,6);
        int M3 = r.Next(0,21);
        string Mnames = Constanant[M2] + Vowel[M1] + Constanant[M3];
        
    
        int Lc = r.Next(0,21);
        int LB = r.Next(0,6);
        int LN = r.Next(0,21);
        int LK = r.Next(0,21);
        int LA = r.Next(0,6);
        int LM = r.Next(0,21);
        int LE = r.Next(0,6);
        string Lname = Constanant[Lc] + Constanant[LE] + Vowel[LB] + Constanant[LK] + Vowel[LA] + Constanant[LM];
        

        template = Fname + " " + Mnames + " " + Lname;

        Yearly[x] = (HourlyWages[x] + .25) * 40 * 50;
        
        for(int z = 0; z < x; z++)
        {
            if(String.Equals(Names[z], template))
            {
                validName = false;
            }
        }

    

        /*for(int y = x+1; y<FirstNames.Length; y++)
        {
        if(FirstNames[x] == FirstNames[y])
        {
            repeat ++;
            break;
        }

    }*/

    Names[x] = template;

    }
}

Console.WriteLine($"Here is how many repeat names there are {repeat}");

for(int i = 0; i < Names.Length; i++)
{
 Console.WriteLine($"{i + 1}:  {Names[i]}\n        Hourly Salary ${HourlyWages[i] + .25:00.00}\n      Yearly Salary ${Yearly[i]}");
 Console.WriteLine($"{repeat} repeat(s)");
}