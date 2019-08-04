--C# Delegates--

C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. 
The reference can be changed at runtime. 

Delagates are especially used for implementing 'events' and the 'call-back methods'. All delegates are implicitly derived  from the System.Delegate class. 

-Declaring Delegates 
 
Delegate declaration determines the methods that can be referenced by the delega. A delegate can refer to a method, which has the same signature as that 
of the delegate. 

For example, consider a delegate - 

public delegate int MyDelegate(string s);

The preceding delegate can be used to reference any method that has a single string parameter and returns an int type variable. 

Syntax for delegate declaration is - 

delegate <return type> <delegate-name> <parameter list>


-Instantiating Delegates 
Once a delegate type is declared, a delegate object must be created with the new keyword and be associated with a particular method.  
When creating a delegate, the argument passed to the new expression is written similar to a method call, but without the arguments to the method. For Example: 

>declaring the delegate
public delegate void printString( string s ) 
...
> create printString delegate obhject with new keyword.
printString ps1 = new  printString(WriteToScreen);
printString ps2 = new  printString(WriteToFile);

Tutorial examples demonstrates declaration, instantiation, and use of a delegate that can be used to reference methods that have same signature as that of the delegate. 

--Multicasting of a Delegate
Delegate objects  can be composed using the "+" operator. A composed delegate calls the two delegates it was composed from. 
Only delegates of same type can be composed. The "-" operator can be used to remove a compenent delegate from a composed delegate. 

Using this property of delegates you can create an invocation list of  methods that will be called when a delegate is invoked.  This is called 
multicasting of a delegate. 
