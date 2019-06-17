--C# Multithreading--

A thread is defined as the execution path of a program.
Thread bir programın icra yolu olarak tanımlanır. 

Each thread defines a unique flow of control.
Her bir thread kontrolün uniq bir akışını sağlar, tanımlar.

If your application involves complicated and time consuming operations, then it is often helpful to set different execution paths or threads, with each thread performing a particular job.
Eğer senin uygulaman zaman alıcı ve karmaşık işlemlere sahip ise akabinde program için her bir threadin farklı belli bir işi gerçekleştirdiği,  farklı icra yolları veya farklı threadler setlemen faydalı olucaktır. 

Thread --> icra yolu, iş parçacığı
process --> süreç  
herbir process birden fazla threadlerden  oluşur. 

Threads are lightweight processes. 
Threadler hafif processlerdir (süreçlerdir). 

One common example of use of thread is implementation of concurrent programming by modern operating systems. 
Threadin kullanımının en yaygın örneği modern işletim sistemleri tarafından yapılan eş zamanlı programlamanın uygulanmasıdır. 

Use of threads saves wastage of CPU cycle and increase efficiency of an application.
Threadlerin kulanımı CPU cycle'lerinden tasarruf sağlar ve uygulamanın verimliliğini artırır.  


So far we wrote the programs where a single thread runs as a single process which is the running instance of the application.
Buraya kadar biz uygulamanın instance'ı olarak koşan single process olarak single threadin koştuğu programlar yazdık. 
yani buraya kadar yazdığımız programlar tek process tek thread programlardır. 

However, this way the application can perform one job at a time.
Ancak bu yol ile uygulama bir seferde veya bir kerede bir job veya bir iş gerçekleştirebilir.

To make it execute more than one task at a time, it could be divided into smaller threads.
Uygulamayı bir seferde birden daha fazla iş yürütebilir hale getirmek için , uygulama küçük iş parçacıklarına threadlere bölünmelidir.  



---- Thread Yaşam Döngüsü (Thread Life Cycle)


The life cycle of a thread starts when an object of the System.Threading.Thread class is created and ends when the thread is terminated or completes execution.
Threadin yaşam döngüsü  System.Threading.Thread classının objectinin creat edilmesiyle başlar ve threadin sonlandırılmasıya veya icrasının bitmesiyle threadin yaşam döngüsü de biter. 

Following are the various states in the life cycle of a thread −
Aşağıda threadin yaşam döngüsündeki çeşitli durumlar listelenmiştir. 


The Unstarted State − 
Başlanmamış Durum  -  
Threadin instance ı oluşturulup Start methodunun çağrılmadığı durum threadin Başlanmamış Durumudur.

The REady State -- 
Thread Hazır Durum -- 
Threadin koşmaya hazır olduğu ve cpu cycle ı beklediği bir durumdur. 

The Not Runnable State − 
Thread Çalıştırılamaz Durum: 
Thread aşağıdaki durumlarda çalıştırılamaz: 
1--> Sleep method has been called : Sleep methodu çalıştırıldığında 
2--> Wait method has been called: Wait  methodu call edildiğinde. 
3--> Blocked by I/O operations: I/O işlmeleri tarafından  blocklandığında. (Threadleri unmanaged yapan durum işte bu durumdur. yani yönetilemeyen kod denme sebebi bu durumdan kaynaklanır.)

The Dead State −
Thread Ölü Durumu: 
Threadin icrasını tamamladığı veya threadin abort edildiği durumdur bu durum. 

----The Main Thread
In C#, the System.Threading.Thread class is used for working with threads. 
C# da System.Threading.Thread class ı thread ler ile çalışmak için kullanılır. 

It allows creating and accessing individual threads in a multithreaded application.
System.Threading.Thread class ı multithreaded uygulamalarda birbirinde bağımsız threadleri oluşturmaya ve onlara erişmeye imkan sağlar. 

The first thread to be executed in a process is called the main thread.
Bir process de ilk icra edilen thread main thread olarak adlandırılır. 

When a C# program starts execution, the main thread is automatically created.
C# programı icraya başladığında main thread otomotik olrak create edilir.  

The threads created using the Thread class are called the child threads of the main thread.
Thread classı kullanılarak olşturulan threadler  main threadin child threadleri olarak isimlendirilirler.  

You can access a thread using the CurrentThread property of the Thread class.
Thread classının currentthread propertysini kullanarak  sen threadlere erişebilirsin.   


-----Properties and Methods of the Thread Class

The following table shows some most commonly used properties of the Thread class −
Aşağıda thread classının en yaygın kullanılan propedrtiesşerinden bir kaçını listelicez: 

1--> CurrentContext
Gets the current context in which the thread is executing.
Threadin icra olduğu mevcut contexti return eder.  

2--> CurrentCulture
Gets or sets the culture for the current thread.
Mevcut thread için culture bilgisini get veya set eder.  

3--> CurrentPrinciple
Gets or sets the thread's current principal (for role-based security).
Threadin mevcut sorumlusunu get veya set eder (rol bazlı güvenlik için). 

4--> CurrentThread
Gets the currently running thread.
Mevcut olarak koşan threadi get eder. 

5--> CurrentUICulture
Gets or sets the current culture used by the Resource Manager to look up culture-specific resources at run-time.
Resource manager tarafında  kullanılan mevcut culture bilgisini run-time da  culture-specific kaynaklarına bakmak araştırmak için get veyya set eder.  

6--> ExecutionContext
Gets an ExecutionContext object that contains information about the various contexts of the current thread.
Mevcut thread'in çeşitli contextleri hakkında bilgiler içereen  ExecutionContext object'ini return eder. 

7--> IsAlive
Gets a value indicating the execution status of the current thread.
Mevcut threadin icra durumunu  gösteren değeri get eder. 

8--> IsBackground
Gets or sets a value indicating whether or not a thread is a background thread.
threadin background thread'i olup olmadığını gösteren değeri get veya set eder. 

9--> IsThreadPoolThread
Gets a value indicating whether or not a thread belongs to the managed thread pool.
Threadin managed thread pooluna ait olup olmadığını gösteren  değeri get eder.  

10 --> ManagedThreadId
Gets a unique identifier for the current managed thread.
Mevcut yönetilen thread için uniq tanımlayıcı get eder.  

11 --> Name
Gets or sets the name of the thread. 
Threadin adını get veya set eder.   

12--> Priority
Gets or sets a value indicating the scheduling priority of a thread.
Threadin tarifeleme  önceliğini belirleyen değeri get veya set eder. 

13 --> ThreadState
Gets a value containing the states of the current thread.
Mevcut threadin durumlarını içeren değeri get eder.


The following table shows some of the most commonly used methods of the Thread class −
Aşağıda Thread classının en yaygın kullanılan methodlarından bir kaçını listelicez: 

1 --> public void Abort()
Raises a ThreadAbortException in the thread on which it is invoked, to begin the process of terminating the thread. Calling this method usually terminates the thread.
Thread'in sonlanma işlemini başlatmak için çağrılan thread de ThreadAbortException exceptionını fırlatır. Bu methodu call etmek genellikle threadi sonlandırır. 

2--> public static LocalDataStoreSlot AllocateDataSlot()
Allocates an unnamed data slot on all the threads. For better performance, use fields that are marked with the ThreadStaticAttribute attribute instead.
Bütün threadler üzerinde isimlendirilmemiş data slotu (veri yuvası) tahsis eder. Daha iyi performans için bunun  yerine ThreadStaticAttribute attribute ile işaretlenmiş fieldleri kullan. 

3--> public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
Allocates a named data slot on all threads. For better performance, use fields that are marked with the ThreadStaticAttribute attribute instead.
Bütün threadler üzerinde  isimlendirilmiş data slot (veri yuvası) tahsis eder bu method. Daha iyi performans için bunun  yerine ThreadStaticAttribute attribute ile işaretlenmiş fieldleri kullan.

4--> public static void BeginCriticalRegion()
Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception might jeopardize other tasks in the application domain.
Application domaininde threadin sonlanması veya işlenemeyen bir exceptionun etkilerinin diğer tasklara zarar verebileceği bir kod bölgesine icarnın girdiğini host a bildirir.

5--> public static void BeginThreadAffinity()
Notifies a host that managed code is about to execute instructions that depend on the identity of the current physical operating system thread.
Managed Code'un mevcut fiziksel işletim sistemi threadini kimliğine bağlı emirleri icra etmek üzere olduğunu hsta bildirir.  

6--> public static void EndCriticalRegion()
Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception are limited to the current task.
İcranın thread sonlanmasının ve işlenmeyen bir exceptionın etkilerinin  mevcut task ile sınırlandırıldığı bir kod bölgesine girdiğini host a bildirir.

7--> public static void EndThreadAffinity()
Notifies a host that managed code has finished executing instructions that depend on the identity of the current physical operating system thread.
Managed code'un  evcut fiziksel işletim sistemi threadinin kimliine bağlı emirleri icara etmeyi bitirdiğini hosta bildirir.

8--> public static void FreeNamedDataSlot(string name)
Eliminates the association between a name and a slot, for all threads in the process. For better performance, use fields that are marked with the ThreadStaticAttribute attribute instead.
Procesdeki var olan bütün threadler için slot ve name arasındaki bağlantıyı ortadan kaldırır.  Daha iyi performans için bunun  yerine ThreadStaticAttribute attribute ile işaretlenmiş fieldleri kullan.

9--> public static Object GetData(LocalDataStoreSlot slot)
Retrieves the value from the specified slot on the current thread, within the current thread's current domain. For better performance, use fields that are marked with the ThreadStaticAttribute attribute instead.
mevcut Threadin mevcut domainindeki mevcut thread üzerindeki belirlenmiş slotdan değeri return eder.  Daha iyi performans için bunun  yerine ThreadStaticAttribute attribute ile işaretlenmiş fieldleri kullan.

10--> public static AppDomain GetDomain()
Returns the current domain in which the current thread is running.
mevcut threadin koştuğu mevcut domaini  return eder. 

11 --> public static AppDomain GetDomainID()
Returns a unique application domain identifier
Unique uygulama domain tanımlaycısını  return eder.  

12--> public static LocalDataStoreSlot GetNamedDataSlot(string name)
Looks up a named data slot. For better performance, use fields that are marked with the ThreadStaticAttribute attribute instead.
isimlendirilmiş data slotunu araştırır. Daha iyi performans için bunun  yerine ThreadStaticAttribute attribute ile işaretlenmiş fieldleri kullan.

13 --> public void Interrupt()
Interrupts a thread that is in the WaitSleepJoin thread state.
WaitSleepJoin thread durumunda olan threadi keser. 

14 --> public void Join()
Blocks the calling thread until a thread terminates, while continuing to perform standard COM and SendMessage pumping. This method has different overloaded forms.
Thread standart com and sendmessage pumping işlemlerini icraya devam ediyorken, thread sonlana kadar  çağrılan threadi bloklar.  Bu join methodunun farklı aşırı yüklenmiş biçimleri mevcuttur.  

15--> public static void MemoryBarrier()
Synchronizes memory access as follows: The processor executing the current thread cannot reorder instructions in such a way that 
memory accesses prior to the call to MemoryBarrier execute after memory accesses that follow the call to MemoryBarrier.
Bu fonksiyonun görevi bellek erişimini senkronize etmektir. 
Bellek erişimini aşağıdaki gibi senkronize eder:  
Mevcut threadi icra eden işlemci MemoryBarrier icarsından önce bellek erişimi yapıldığı durumlarda emirleri tekrardan sıralayamaz, olması gereken  
MemoryBarrier icrasını takip eden bellek erişimidir. MemoryBarrier icrasından sonra belleke erişilirse bellek erişimi senkronize olur ve işlemci emirleri tekrardan sıralayabilir. 

16--> public static void ResetAbort()
Cancels an Abort requested for the current thread.
Mevcut thread için  abort isteğini cancel eder. 

17--> public static void SetData(LocalDataStoreSlot slot, Object data)
Sets the data in the specified slot on the currently running thread, for that thread's current domain. For better performance, use fields marked with the ThreadStaticAttribute attribute instead.
Bu threadin mevcut mevcut domaininde mevcut koşan threaddeki  belirlei bir slota data setler.   Daha iyi performans için bunun  yerine ThreadStaticAttribute attribute ile işaretlenmiş fieldleri kullan.


18 --> public void Start()
Starts a thread.
Threadi başlatır. 

19 --> public static void Sleep(int millisecondsTimeout)
Makes the thread pause for a period of time.
Belli bir time periodu için  threadi pause moduna alır. Yani threadi anlık durdurur. 

20 --> public static void SpinWait(int iterations)
Causes a thread to wait the number of times defined by the iterations parameter
the iterations parameter tarafından tanımlanan süre kadar threadin beklemesine sebeb olur. 

21 --> 

public static byte VolatileRead(ref byte address)

public static double VolatileRead(ref double address)

public static int VolatileRead(ref int address)

public static Object VolatileRead(ref Object address)

Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache. 
This method has different overloaded forms. Only some are given above.

Fieldın değerini okur. Değer pc deki işlmecinin cache durumundan veya işlemcilerin sayısından bağımsız olarak işlemcilerin herhangi birisi tarafından  en son yazılan değerdir.
Bu method farklı aşırı yüklenmiş formlara sahiptir. Sadece birkaçı yukarıda verilmiştir.  

22 --> 

public static void VolatileWrite(ref byte address,byte value)

public static void VolatileWrite(ref double address, double value)

public static void VolatileWrite(ref int address, int value)

public static void VolatileWrite(ref Object address, Object value)

Writes a value to a field immediately, so that the value is visible to all processors in the computer. This method has different overloaded forms. Only some are given above.
Fielde değeri  doğrudan doğruya yazar, bu yüzden bu değer pc deki bütün işlemcilere  görünür olur. Bu methodun farklı aşırı yüklenmiş versiyonları mevcuttur. Sadece bir kaçı yukarıda verilmiştir. 

23 --> public static bool Yield()

Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the thread to yield to.
Mevcut threadin mevcut işlemci üzerinde koşmaya hazır olan bir diğer threade icrayı vermesine sebeb olur. İcranın verileceği threadi işletim sistemi kendisi seçer. 


---Creating Threads
Threads are created by extending the Thread class.
Threadler Thread classının genişletilmesiyle oluşturulurlar. 

The extended Thread class then calls the Start() method to begin the child thread execution.
Genişletilmiş thread classı,  akabinde  child_thread  icrasını başlatabilmek için Start() method unu call eder. 


---Managing Threads
The Thread class provides various methods for managing threads.
Thread classı threadleri yönetmek için çeşitli methodlar sağlar. 

The following example demonstrates the use of the sleep() method for making a thread pause for a specific period of time.

önmüzdeki bir sonraki örnek belli bir zaman periodunda threadi pause moduna almak için sleep() methodunun kullanılmasını  göstericek. 
Sleep methodu threadleri yönetmek için Thread classının sağlamış olduğu bir methodtur. 


--Destroying Threads
The Abort() method is used for destroying threads.
Abort methodu threadleri destroy etmek için kullanılır. 

The runtime aborts the thread by throwing a ThreadAbortException.
Runtime threadi ThreadAbortException ı fırlatarak sonlandırır.

This exception cannot be caught, the control is sent to the finally block, if any.
Bu exception yakalanamaz, control finally bloğuna gönderilir, eğer böyle bir exception fırlatılır ise. 





































