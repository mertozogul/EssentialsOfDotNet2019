--C# Data Types--

 *For Detail Informations --> http://www.tutorialsteacher.com/csharp/csharp-data-types
Data  Types In  C#
-Value Type
-Reference Type
-Pointer Type (This type will be processed in 'Unsafe Codes' section)
****************************************************************************************
Value Type'ın Datası Doğrudan Ramde Doğrudan Stack'de Tutulur. Direk data stackde bulunur.
The following data types are reference type:  
-String (built-in reference types)
-All arrays, even if their elements are value types. (built-in reference types)
-Object Type  (built-in reference type)
-Dynamic Type  (built-in reference type)
-Class (user-defined reference types)
-Delegates (user-defined reference types)
The following data types are value type:
-Primitive  Data Types (int, double, float ...)
-Structs
-Enums
*******Reference types have null value by default, when they are not initialized.
*******A value type variable cannot be null because it holds a value not a memory address.
* İkisi İçinde Ortak Ve Çok Önemli Bir Cümle :
* **********Value types and reference types stored in Stack and Heap in the memory depends on the scope of the variable.

int i;
Eğer value type variable'ı bu şekilde ilklendirmeden initialize etmeden kullanmaya çalışırsak build error alırız.
Yukarıdaki declaration build error aldırır. Value Type variable'ın doğru declaration'ı aşağıdadır. 
int i = 100;
Bu şekilde bir declaration bize build error aldırmaz.
***However, value type field in a class can be declared without initialization (field not a local variable in the function) . 
    It will have a default value if not assigned any value, e.g., int will have 0, boolean will have false and so on.


