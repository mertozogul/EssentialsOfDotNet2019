--C# Anonymous Methods--

We discussed that delegates are used to reference any methods that has the same signature as that of the delegate. 
In other words, you can call a method that can be referenced by a delegate using that delegate object.  
Anonymous methods provide a technique to pass a code block as a delegate parameter. Anonymous methods are the methods without name, just the body. 


You need not specify the return type in an anonymous method; it (return type) is inferred  from the return statement inside the method body. 

Numberchange nc = delegate(x){
  Console.WriteLine("Anonymous Method: {0}", x);
};

yukarıda anonymous method ile delegate instancesının oluşturulmasında görüldüğü gibi anonymous method da herhangi bir dönüş tipi tanımlanmamış. 


##Writing an Anonymous Method
Anonymous methods are declared with the creation  of the delegate instance, with a delegate keyword. For example, 

delegate void NumberChanger(int n); 
...
NumberChanger nc = new delegate(int x) {
  Console.WriteLine("Anonymous Method: {0}", x);
}; 


The code block Console.WriteLine("Anonymous Method: {0}", x); is the body of the anonumous method. 

The delegate could be called both with anonymous methods as well as named methods in the same way, i.e., by passing 
the method parameters to the delegate object. 

For example, 
nc(10);
