--C# Collections--

Collection classes are specialized classes for data storage and retrieval. These classes provide support for stacks, queues, lists, and hash tables. 
Most collection  classes implement the same interfaces. Collection classes serve various  purposes, such as allocating memory dynamically to elements 
and accessing a list of items on the basis of an index etc.  These classes create collections  of objects of the Object class, which is the base class 
for all data types in C#. 


--Various Collection Classes and Their Usage  
The following are the various commonly used classes of the System.Collection namespace. 

--ArrayList Class 
It represents an ordered  collection  of an object that can be indexed individually. It is basically an alternative to an array. However, unlike array you can add 
and remove items from a list at specified position using an index and the array resizes itself automatically.
It also allows dynamic memory allocation, adding, searching and sorting items in the  list.

--Hashtable Class
The Hashtable class represents a collection of key-and-value pairs that are organized based on the hash code of the key. 
It (hashtable class) uses  the key to access the elements in the collection. 

A hash table is used when you need to access elements by using key, and you can identify a useful key value. 
Each item in the hash table has a key/value pair. The key is used to access the items in the collection. 

--SortedList Class (combination of the arraylist and hashtable)
The SortedList class represents a collection of key-and-value pairs that are sorted by the keys and are accesible by key and by index. 

A sorted list is a combination of an array  and a hash table. It contains a list of items that (list of items) can be accessed using a key or an index. If you access 
items using an index, it (sortedlist) is an arraylist, and if you access items using a key, it (sortedlist) is a hash table. 

::sorted list items are accessed both by key and index, so that sorted list is combination of array list and hashtable. 

The collection of items is always sorted by the key value. 

--Stack Class
It represents a last-in, first-out collection of object. It is used when you need a last-in, first-out access of items. When you add an item in the list, it is called pushing the item and  
when you remove item, it is called popping the item. 

--Queue Class
It represents a first-in, first-out collection of object. It is used when you need a first-in, first-out access of items. 
When you add an item in the list, it is called enqueue, and when you remove an item, it is called dequeue. 

--BitArray Class
The BitArray class manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on (1) and false indicates the bit is off (0). 
It is used when you need to store the bits but do not know the number of bits in advance. you can access items from the bitarray collection by using  
an integer index, which starts from zero. 