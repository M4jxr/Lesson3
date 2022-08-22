//if (20 > 18)
//{
//    Console.WriteLine("20 is greater than 18");
//}

//int x = 20;
//int y = 18;
//if (x > y)
//{
//    Console.WriteLine("x is greater than y");
//}

//int time = 20;
//if (time < 18)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}

//int day = 4;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//}

//int day = 4;
//switch (day)
//{
//    case 6:
//        Console.WriteLine("Today is Saturday.");
//        break;
//    case 7:
//        Console.WriteLine("Today is Sunday.");
//        break;
//    default:
//        Console.WriteLine("Looking forward to the Weekend.");
//        break;


//int b = a == 1 ? 10 : 15;

//int time = 20;
//if (time < 18)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}


//string b = time < 18 ?("Good day.") : ("Good evening.");
//Console.WriteLine(b);

//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 5);

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}


//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);

//for (var i = 0; i < 10; i++)
//{
//    if (i > 5) break;
//    Console.Write(i);
//}

//for (var i = 0; i < 10; i++)
//{
//    if (i == 5) continue;
//    Console.Write(i);
//}

//while (false)
//{
//    Console.WriteLine("Hello, World");
//}

//do
//{
//    Console.WriteLine("Hello, World");
//} while (false);

//for (var i = 10; i < 15; i++) 
//{
//    Console.Write('a');
//}

//string pa = "hi";
//if (pa =="hii") 
//{
//    Console.WriteLine(pa);

//}
//else Console.WriteLine("erhgrteh");

//switch (pa)
//{
//    case "1":
//        Console.WriteLine(pa);
//        break;
//    default:
//        Console.WriteLine("ehrth");
//        break;
//}





int x = 0;

Console.WriteLine("write number X");
if (!Int32.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("this is not a number");
    return;
}
int y = 0;
Console.WriteLine("write number Y");
if (!Int32.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("this is not a number");

    return;

}



int sum = 0;

for (int i = x; i <= y; i++)
{
    sum = sum + i;

}
Console.WriteLine("Sum: " + sum);

//checked

