--C# Reflection--
(Reflection && Attributes)   
   Bir önceki chapter da hazırladığımız custom attributeları burda reflection objeleri ile retrieve edicez. 

   The program has informations at runtime. This runtime information is named  metadata.  

   Reflection objects are used for obtaining type information at runtime. The classes that give access  to the metadata 
   of a running program  are in the System.Reflection  namespace. 

   The System.Reflection namespace contains classes that allow you to obtain information about the application and 
   dynamically add types, values, and objects to the application. 

   --Applications Of Reflection
    Reflection has the following applicaitons: 
	** It allows view attribute information at runtime. 
	** It allows examining various types in an assembly and instantiate these types. 
	** It allows late binding to methods and properties. 
	** It allows creating new types at runtime and then performs some tasks using those types. 

	--Viewing Metadata 
	We have mentioned in the preceding chapter that using reflection you can view the attribute information. 
	The MemberInfo object of the System.Reflection  class needs to be initialized for discovering the attributes associated with a class.
	To do this, you define an object of the target class, as: 

	System.Reflection.MemberInfo info = typeof(MyClass); 
