--C# Unsafe Codes--

 MSDN notes
--------------------------------
--- msdn tutorial url: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types
Pointer types do not inherit from object and no conversions exist between pointer types and object.
Also, boxing (value type --> object type) and unboxing (object type --> value type) do not support pointers.

--> pointer tiplerin reference tiplerini point etmeme sebebi:  
A pointer cannot point to a reference or to a struct that contains references, because an object reference can be garbage collected even if a pointer is pointing to it. 
--> Pointer referencı veya reference  içeren structı point edemez. Çünki reference garbage collected olabilir, hatta bir pointer onu gösterse bile garbage collected olabilir. 
The garbage collector does not keep track of whether an object is being pointed to by any pointer types.
--> Garbage collector objectin pointer tarafından point edilip edilmediğine bakmaz. Direk objecti garbage collected yapar. Bu sebebten 
--> pointer type reference tipdeki değişkenleri gösteremez. Örnek string. string* spr; diye bir pointer yoktur. 

--> myType* bu bir tiptir.string gibi, int gibi bir tiptir. 
--> string reference tiptir, int value tiptir, myType* da pointer tiptir. 

The value of the pointer variable of type myType* is the address of a variable of type myType. 
int i_var = 0;
int* i_ptr; 
i_ptr = &i_var;
int* tipinin pointer değişkeni i_ptr nin değeri int tipindeki i_var değişkeninin adresidir.

int* p   --> p is a pointer to an integer 
int** p  --> p is a pointer to a pointer to an integer     
int*[] p --> p is a single-dimensional array of pointers to integers
char* p  --> p is a pointer to a char.
void* p  --> p is a pointer to an unknown type. 

The pointer indirection operator * can be used to access  the content at the location pointed to by the pointer variable. For example: 
consider the following declaration: 
-->  The pointer indirection operator * pointer değişkeni tarafında point edilen lokasyondaki içeriğe erişmek için kullanılabilir.  
        
int* myVariable;

The expression *myVariable denotes the int variable found at the address contained in myVariable.  
--> *myVariable myVariable da saklanan adreste bulunan int değişken anlamına gelir.
        
    Operator/Statement	            Use
            *	                        Performs pointer indirection.
            ->                        Accesses a member of a struct through a pointer. (belleğin belirlenen adreste tutulan değerini gösterir.)
            &	                        Obtains the address of a variable.
            []	                    Indexes a pointer.
        ++ and --	                Increments and decrements pointers.
        + and -	                    Performs pointer arithmetic.
    ==, !=, <, >, <=, and >=           Compares pointers.
        stackalloc operator	        Allocates memory on the stack. (click detail after..)
        fixed statement                Temporarily fixes a variable so that its address may be found. (click detail after..)
        

TutorialsPoint Notes
--------------------------------
C# kod bloğunun fonksiyonun'da fonksiyonu unsafe belirteç ile işaretliyerek pointer değişken kullanımına imkan sağlar.  The unsafe code (güvenilir olmayan) veya unmanaged code (yönetilemeyen yani, çalışırken kod  
harici donanımsal olayların olabilceği, yazılımcının kontrolünden çıkabilen yani yönetilemeyen) pointer değişkenini kullanan kod bloğudur. 


Pointers / İşaretçiler / belli bir bellek bölgesine işaret edenler. 
Pointer tipindeki değişkenlerin değerleri diğer değişkenlerin bellek alanlarındaki açık adresleridir.  

Diğer değişkenlerde veya sabitlerde olduğu gibi herhangi bir değişkenin bellek bölgesindeki adresini pointer tipindeki değişkenlerde saklamak için  önce pointer 
tipindeki değişkenin  bildirimi yapılması gerekir.  

pointer bildiriminin genel sentaxı: 
type* var_name; 

aşağıdakiler geçerli pointer değişkenleridir.

int* ip; /* int* int pointer tiinde bir değişken bildirimi, int tipinde bir değişkeni gösterir.  */
double* dp;
float* fp; 
char* ch; 
-invalid-  string* sp; --> bu  geçerli değildir.  pointer tipindeki değişkenler string reference tipindeki bir değerin bellek deki adresini saklıyamazlar.  
--Retrieving the Data Value Using a Pointer
Pointer değişkeni tarafından tutulan adreste veya  reference edilen bellek bölgesindeki tutlan değere tostring methoduyla erişilebilir.
--Passing Pointers as Parameters to Methods
Pointer değişkenleri methoda parametre olarak geçirilebilir.

--Accessing Array Elements Using a Pointer

C# da array'in adı ile (int[] tipinde) arrayin datasının tipi ile aynı tipe sahip pointer değişkeni (aslınmda biz burada  int* ile int[] tipinin aynı olup olamdığını kıyaslıyoruz.) aynı değişken tipinde  
değildir.  Örnek olarak int* p  and int[] p aynı tipte değişkenler değillerdir.  
Neden ??? 
Çünki sen pointer değişkeni p nin değerini bellekte sabit olmadığından dolayı artırabilirsin ancak array adresi bellekte sabitdir, ve sen array değişkenini artıramzsın. 

bu neden ile , eğer array'in datasına pointer değişkeni kullanılarak erişmeye ihtiyacın olur ise, C ve C++ da geleneksel olarak yaptığımız  gibi, senin pointerı 
fixed keywordunu kullanarak  fixlemeye ihtiyacın olucaktır. 

-- Compiling Unsafe || Unmanaged (zaten unmanaged olduğunda dolayı unsafe demeyi tercih ettik...) Code --> Project properties den ayarlanıyor, yada komut satırından da ayarlıyabilirsin.


