# Abstract Factory (creational pattern)

this is the first of the creational patterns. a factory is a class that knows how to construct a specific object type or various types of objects. it hides the complexity of constructing such an object from the client.

if has a very hight frequency of occurance and it is formally defined as: provide an interface for creating families of related or dependent objects without specifying their concrete classes.

We have an abstract factory interface where we define the basic methods we want our concrete factory classes to have 

We create concrete factories that return abstract objects in their definition, but instantiate concrete objects inside. Returning abstract object from this concrete factory ensures we can deal with returned object types whatever they are (think of nested factories for example) 

The client then uses a specific factory internally to generate it's state. 

Running the client's main method should allow defined objects to interact with each other 


# Problem description

CIA wants to model construction of the following mobile phone devices, in order to know how to better eavesdrop: 

* Samsung S9+ 
* Samsung S10 
* OnePlus 5T 
* OnePlus 6 
* OnePlus 6T 
* Google Pixel XL 
* IPhone X 
* IPhone Xs 
 
Use the factory pattern to construct these devices knowing that each mobile phone is constructed of (you put the specs): Camera, Processor, RAM, Internal Storage 


# Resources

* https://www.dofactory.com/net/abstract-factory-design-pattern 