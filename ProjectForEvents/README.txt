--C# Events--

Events are user actions such as key press, clicks, mouse movements, etc., or some occurrance such as system generated notifications.
Applications need to respons to events when they occur. For example interrupts (as sample events). Events are used for inter-process communication.


--Using Delegates with Events 
The events are declared and raised in a class and associated with event handlers (in subscriber class) using delegates within the same class or some other class. 
The class containing the event is used to publish  the event. This is called the publisher class. Some other class that accepts this event is called subscriber class. 
Events use the publisher-subscriber model.

  ****Publisher Class (ClassCaller.cs)
A publisher is an object that contains the definition of the event and the delegate. The event-delegate association is also defined in this object. 
A publisher class object invokes the event and it is notified to other objects. 

  ****Subscriber Class (Subscriber.cs)
A subscriber is an object that accepts the event and provides an event handler. The delegate in the publisher class invokes the method (event handler) of the subscriber class.  

--Declaring Events 

To declare an event inside a class, first delegate type for the event must be declared. For example: 

public delegate string MyDel(string str); 

Next, the event itself is declared, using the event keyword - 

event MyDel MyEvent; 

****Event invokes the delegate  when it is raised. 