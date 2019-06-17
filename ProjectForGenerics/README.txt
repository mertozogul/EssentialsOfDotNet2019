--C# Generics--

Generics allow you to define the specification of the data type of the programming elements in a class or a method, until it is actually 
used in the program. In other words, generics allow you to write a class or method that can work with any data type. 

You write the specifications for the class or the method, with substitute parameters for data types. 
When the compiler encounters  a constructor for the class or a function  call for the method, it generates code to handle the specific data type.  

###Features of Generics 
Generics is a technique that enriches your programs in the follwing ways: 
1--> It helps you to maximize code reuse, type safety, and performance. 
2--> You can create generic collection classes. The .Net Framework class library contains several new generic collection classes in the System.Collection.Generic
namespace. You may use these generic collection classes instead of the collection classes in the System.Collection namespace.  
3--> You can create your own generic interfaces, classes, methods, events,  and delegates. 
4--> You may create generic classes constrained  to enable access to methods on particular data types. 
5--> You may get information on the types used in a generic data type at run-time by means of reflection. 

###Generic Methods 
We can declare generic methods with a type parameter. 


###Generic Delegates
You can define generic delegate with type parameters. For example - 
delegate T NumberChanger<T>(T n); 

