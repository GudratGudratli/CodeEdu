//ev tapsiriqi 3. !!! LOOPS !!!
void task1()
{
    var input = 63;
    var ans = 1;
    var num=2;
    while (num<input)
    {
        
        num *= 2;
        ans++;
    }
    var digit1 = input - num/2;
    var digit2 = num - input;
    console.log(digit1); //Kicik olan
    console.log(digit2);

}

void task2()
{
    var inputnum = 123;
    var answer = 0;
    while (inputnum > 0) 
    {
        answer += inputnum % 10;
        inputnum = inputnum / 10;
    }
    console.log(answer);
}

void task3()
{
    var inputnum = 123;
    var answer = 0;
    for(var i = 2; i < inputnum; i++)
    {
        if(inputnum % i == 0)
        {
            answer++;
        }
        
    }
    if (answer == 0)
    {
        console.log("Bu eded sadedir");
    }
    //else if (Answer <= 0)
    //{
    //    Console.WriteLine("Menfi eded daxil etmek olmaz!");
    //}
    else 
    {
        console.log("Bu eded Murekkebdir");
    }
    console.log("Bolenlerinin sayi: " + answer);
}
task1();
task2();
task3();

//1.Verilmiş ədədin 2 -in neçənci qüvvəti(və ya neçənci qüvvətinə yaxın) olduğunu tapın
//2. Ədədin rəqəmləri cəmini tapın
//3. Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın