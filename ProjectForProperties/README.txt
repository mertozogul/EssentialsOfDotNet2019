--C# Properties--

Properties are named members of class, structures, and interfaces.

Member variables or methods in class or structures are called Fields.  Properties are an extension of fields and are accessed using the same syntax. 
----------------------------------------------------------------------------------------------------------------------------------------------------

They use accessors through which the values of the private fields can be read, written or manipulated. Properties use get, set accessors. 

Properties do not name the storage locations. Instead, they have accessors that read, write or compute their values. 

For Example, let us have a class named Student, with private fields for age, name, and code. We cannot directly access these fields from outside the class scope, 
but we can have properties for accessing  these private fields.  

--Accessors--
The accessor of a property contains the executable  statements that helps getting (reading or computing) or setting (writing) the property. 
The accessors declarations can contain a get accessor, a set accessor, or both. 


--Abstract Properties--

An abstract class may have an abstract property, which should be implemented in the derived class.   


Properties can be declared as abstract and virtual.