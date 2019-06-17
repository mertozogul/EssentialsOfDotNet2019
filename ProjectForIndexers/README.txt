--C# Indexers--

An indexer allows an object to be indexed such as an array. When you define 
an indexer for a class, this class behaves similar to a  virtual array. You 
can then access the instance of the class using the array access operator ([]). 

--USE OF INDEXERS
 Declaration of behavior of an indexer is to some extent similar to a property. Similar to the properties, you use the get and set accessors for defining 
 an indexer. However, properties return or set a specific data member, whereas indexers return or set a particular value  from the object instance.  
 In other words, it breaks the instance data  into smaller parts and indexes each part, gets or sets each part. 

 Defining a property involves providing a property name.  Indexers are not defined with names, but with the this keyword, which refers to the object instance. 


--OVERLOADED INDEXERS 
Indexers can be overloaded. Indexers can also be declared with multiple parameters and each parameter may be a differant type.
It is not necessary that the indexs have to be integers. C# allows indexes to be of other types, for example, a string.    