--C# Static--

Tips: 
	1--> Class adıyla sadece static üyelere erişim sağlarız. Class ister statik ister non-static olsun onun içerisindeki static üyelere class adıyla erişilebilir. 
	2--> Diyelim static olmayan  bir classın nesnesini oluşturdunuz. Bu nesne ile bu classın sadece static olmayan üyelerine erişim sağlıyabilirsiniz.Bu nesne non-static classın içerisindeki static üyeleri
		göremez. Static üyelere her zaman class adıyla erişilebilir.
	3--> Class eğer static ise onu örneklendiremezsin.
	4--> Static classın içerisinde sadece static üyelere izin verilir. 
	5--> Static olmayan bir classın içerisinde hem static  hem non-static üyelere izin verilir. Static olmayan classın doğrudan adıyla static üyelere erişilir, Static olmayan classın objecti ile static
		olmayan üyelere erişim sağlanır.

Points to Remember:
	*Static classes cannot be instantiated using the new keyword
	*Static items share the resources between multiple users.
	*Static cannot be used with indexers, destructors or types other than classes.
	*A static constructor in a non-static class runs only once when the class is instantiated for the first time.
	*A static constructor in a static class runs only once when any of its static members accessed for the first time.
	*All static members are allocated in high frequency heap area of the memory.

