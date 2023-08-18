// See https://aka.ms/new-console-template for more information
using Types_of_Constructors;

Console.WriteLine("Hello, World!");
Employee_parameterized_constructure emp = new Employee_parameterized_constructure(100000); //parameterized constructer

MyClass_Default_Constructure myClass = new MyClass_Default_Constructure(); //default constructure

//static constructure
MyClass_Static_Constructure.print();
//output
//constructure
//method

//copy constructure
MyClass_Copy_Constructure myClass1 = new MyClass_Copy_Constructure("Usman");
MyClass_Copy_Constructure myClassCopy1 = new MyClass_Copy_Constructure(myClass1);

//private constructure
//MyClass_Private_Constructure myClassPrivate = new MyClass_Private_Constructure() //error bcz of private constructure, we neither inherit nor create instance of private constructure class


