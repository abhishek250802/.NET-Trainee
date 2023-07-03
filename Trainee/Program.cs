// See https://aka.ms/new-console-template for more information
using Trainee;

Console.WriteLine("Hello, Guys!");
Console.WriteLine("");

string aFriend = "Scott";
Console.WriteLine("Hello " + aFriend);
Console.WriteLine("");





//Basics of String
string firstFriend = "Harsh";
string secondFriend = "Prajjwal";
Console.WriteLine($"My Friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
Console.WriteLine("");


//Trim exercise
string greeting = "       Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
Console.WriteLine("");

//For replacing the string
string sayHello = "Hello Guys";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello ", "Greeting ");
Console.WriteLine(sayHello);
Console.WriteLine("");

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
Console.WriteLine("");


//Search String
//agr hme string me wo value hogi then it will print true agr nhi hogi then it will print false method used will be CONTAINED
string songLyrics = "When I'm away from you, I'm happier than ever";

var result = songLyrics.Contains("happier");
Console.WriteLine(result);
// or we cn we this also :-Console.WriteLine(songLyrics.Contains("happier"));

Console.WriteLine(songLyrics.Contains("sad"));
Console.WriteLine("");
// We can also search by StartsWith and EndsWith method to searc the value instead of Contains


//Numbers & Integer Math
int a = 18;
int b = 16;
int c = 8;
int d = a + b / c;  // for multiple operation change from here
Console.WriteLine(d);
Console.WriteLine("");

// Numbers and Integer Precision
int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g;
int i = (f + g) % h;
Console.WriteLine($"quotient: {h}");
Console.WriteLine($"renainder: {i}");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integer is {min} to {max}"); // To find the minimum value of integer.
Console.WriteLine("");

// Work with double type

double j = 19;
double k = 17;
double l = 7;
double m = j + k / l;  // for multiple operation change from here
Console.WriteLine(m);
Console.WriteLine("");


//Area of Circle
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
Console.WriteLine();

//Loop
Program1.method1();
Console.WriteLine();

//Array List Collection
//var names = new List<string> { "<name>", "Harsh", "Elina" };
//foreach (var name in names)
//{
//    Console.WriteLine($"Hello {name.ToUpper()}!");
//    Console.WriteLine();
//}
//alternative methoid

//var names = new List<string> { "<name>", "Harsh", "Elina" };
//for (int i = 0;i < names.Count; i++)
//{
//    Console.WriteLine($"Hello {names[i].ToUpper()}");
//    Console.WriteLine();
//}

//Search sort and index
//var names= new List<string> { "Harmeet", "Anam", "Raj", "Aman" };
//string name = "Anam";
//var index = names.IndexOf(name);
//Console.WriteLine($"Found {name} at {index}");

//var names = new List<string> { "Harmeet", "Anam", "Raj", "Aman" };
//string name = "Harsh";
//var index = names.IndexOf(name);
//if(index == -1){
//    Console.WriteLine($"{name} not found");
//} else {
//    Console.WriteLine($"Found {names[index]} at {index}");
//}
//var names = new List<string> { "Harmeet", "Anam", "RAj", "Elina" };
//Console.WriteLine("Pre Sorting:");
//foreach(var name in names )
//{
//    Console.WriteLine(name);
//}

//names.Sort();

//Console.WriteLine();
//Console.WriteLine("Post Sorting:");
//foreach(var name in names )
//{
//    Console.WriteLine(name);
//}

//List of other type
//var fibonacciNumbers = new List<int> {1, 1};

//foreach (var item in fibonacciNumbers)
//    Console.WriteLine(item);

var fibonacciNumbers = new List<int> {1, 1}; //List basic s start krenge

var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; // last number in the list
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; //  second to last number in the list

fibonacciNumbers.Add(previous + previous2); // phle wale number ko sath jodna h, aur attach krna h end p

foreach (var item in fibonacciNumbers) // Print out the list
    Console.WriteLine(item);