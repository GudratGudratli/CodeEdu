using System.Text;
//ev tapsiriqi 3. !!! LOOPS !!!
void Task1()
{
    int Input = 63;
    int Ans = 1;
    int Num = 2;
    while (Num < Input)
    {

        Num *= 2;
        Ans++;
    }
    int Digit1 = Input - Num / 2;
    int Digit2 = Num - Input;
    Console.WriteLine(Digit1); //Kicik olan
    Console.WriteLine(Digit2);

}

void Task2()
{
    int InputNum = Convert.ToInt32(Console.ReadLine());
    int Answer = 0;
    while (InputNum > 0)
    {
        Answer += InputNum % 10;
        InputNum = InputNum / 10;
    }
    Console.WriteLine(Answer);
}

void Task3()
{
    int InputNum = Convert.ToInt32(Console.ReadLine());
    int Answer = 0;
    for (int i = 2; i < InputNum; i++)
    {
        if (InputNum % i == 0)
        {
            Answer++;
        }

    }
    if (Answer == 0)
    {
        Console.WriteLine("Bu eded sadedir");
    }
    //else if (Answer <= 0)
    //{
    //    Console.WriteLine("Menfi eded daxil etmek olmaz!");
    //}
    else
    {
        Console.WriteLine("Bu eded Murekkebdir");
    }
    Console.WriteLine("Bolenlerinin sayi: " + Answer);
}
Task1();

//1.Verilmiş ədədin 2 -in neçənci qüvvəti(və ya neçənci qüvvətinə yaxın) olduğunu tapın
//2. Ədədin rəqəmləri cəmini tapın
//3. Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın