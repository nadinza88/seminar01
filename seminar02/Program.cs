Console.WriteLine ("Введите первое число");

string inputA = Console.ReadLine ();

int numberA = int.Parse (inputA);

Console.WriteLine ("Введите второе число");

string inputB = Console.ReadLine ();

int numberB = int.Parse (inputB);

if (numberA>numberB)

{Console.WriteLine ($"{numberA} - max; {numberB} - min");
} 

else {
    Console.WriteLine ($"{numberA} - min; {numberB} - max");
}
