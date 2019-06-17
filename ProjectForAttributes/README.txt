--C# Attribute--
    An attribute is declarative tag. Declarative tag is used to convey information to runtime about the behaviors of various elements like  
    classes, methods,structures, enumerators, assemblies etc. in  your program.  

.Net Framework provides  two types of attributes: the predefined atributes, custom built attributes.
             
Attributes: 
    --the predefined ( by .net ) 
    --the custom built  ( by proggrammer )

-----------------------------------------
    ****Predefined Attributes****
------------------------------------------
    The .Net Framework provides three pre-defined attributes −
        --> AttributeUsage
        --> Conditional
        --> Obsolete (kullanılmayan, modası geçmiş, eski..)

    -->AttributeUsage
    It specifies the types of items to which the attribute can be applied.   

    [AttributeUsage (
        validon,
        AllowMultiple = allowmultiple,
        Inherited = inherited
    )]
        -validon: The parameter validon specifies the language elements on which the attribute can be placed.  It is a combination  
            of the value of an enumerator  AttributeTargets. The default value is AttributeTargets.All.    
        -AllowMultiple: The  parameter AllowMultiple (optional) provides value for the AllowMultiple property of this attribute, a Boolean Value. 
        If this is true, the attribute is multiuse. The default is false (single use). 
        -The parameter inherited (optional) provides value for the Inherited property of this attribute, a Boolean value. If it is true, the attribute is inherited by derived class. 
        The default value is false (not inherited) 
        Diyelim bu attrtibute class'a uygulanıyor. Eğer bu param true ise bu classdan türetilmiş classlar bu attribute de miras alabilir. False ise bu attribute ü miras alamazlar.  
        Sample Usage -->  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
    --> Conditional
        This Predefined attribute marks a conditional method whose execution depends on a specified preprocessing identifier. 
    It Causes conditional compilation  of method calls, depending  on the specified value such as Debug or Trace. 
    For example, it (conditional attribute) displays the values of the variables while debugging a code. 
    Preprocessor Identifiers --> Debug, Trace
    Syntax For specifying this attribute is as follows: 
    [Conditional( conditionalSymbol)]
    For example,
    [Conditional("DEBUG")]
    --> Obsolete
    This predefined attribute marks a program entity that should not be used. It enables you to inform the compiler 
    to discard a particular target element. For exanple , when a new method is being used in a class and if you still 
    want to retain the old method in the class, you may mark it (the old method) as obsolete by displaying message the new method should be used, instead of the old method.   

Syntax: 
    [Obsolete (message)]
    [Obsolete (message,iserror)]

message: it is string  describing the reason why the item is absolete and what to use instead. 
iserror: it is a boolean value, if its value is true, the compiler should treat the use of the item as an error. Default value is false. (compiler generates  a warning.)
-----------------------------------------
    ****Custom Attributes****
------------------------------------------
The .Net framework allows creation of custom attributes that can be used to store declarative information and can be retrieved at a run-time. 
Creating and using custom attributes involve four steps: 
1--> Declaring a custom attribute. 
2--> Constructing the custom attribute. 
3--> Apply the custom attribute on a target program element.  
4--> Accessing Attributes Through Reflection. (we will make this at next chapter.)
            
1--> Declaring a custom attribute.
	A new custom attribute should is derived from the System.Attribute class. 
	For Example, 
		//a custom attribute BugFix to be assigned to a class and its members
		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
		public class DeBugInfo : System.Attribute
		In the preceding code, we have declared a custom attribute named DeBugInfo.
2--> Constructing the custom attribute.
	Let us construct a custom attribute named DebugInfo, which stores the information obtained by debugging any program. Let it store the following information - 
	  **** The code number for the bug (private)
	  **** Name of the developer who identified the bug. (private)
	  **** Date of last review of the code. (private)
	  **** A string message for storing the developer's remarks (public)
  
  The DebugInfo class has three private properties for storing the first three infos and a public property for storing the message. Hence the bug number, developer's name, and date
  of review are positional parameters of the DEbugInfo class and the message is an optional or named parameter.  
  
  Each attribute must have at least one constructor. The positional parameters (first three private members) should be passed through the constructor. 
  
3--> Applying the Custom Attribute   
The attribute is applied by placing it immediately before its target. 
	
4--> Accessing Attributes Through Reflection. (we will make this at next chapter.)