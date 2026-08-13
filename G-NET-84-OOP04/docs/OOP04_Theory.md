# Assignment 04 Theory Answers

## Question 1: Abstraction

### a) What is abstraction in object-oriented programming?

Abstraction means showing the important parts of an object and hiding the details that are not necessary for the user. For example, a shipment can provide its estimated cost without the user needing to know exactly how that cost is calculated inside the class.

### b) Why is abstraction considered one of the four pillars of OOP?

Abstraction helps make a program easier to understand because it hides unnecessary details and shows only what is needed. It also makes the code easier to maintain and allows different classes to follow the same general design. It can also be used with polymorphism, where we can work with different objects through a common abstract type or interface.

## Question 2: Abstract Classes vs. Interfaces

### a) What is the difference between an abstract class and an interface?

An abstract class is a base class that can contain fields, constructors, normal methods, and abstract methods. Other classes can inherit from it and use the common functionality.

An interface is mainly used to define a contract that a class must follow. A class can implement more than one interface, while it can inherit from only one class.

### b) When would you choose an interface instead of an abstract class?

I would use an interface when different classes need to have the same ability or behavior. For example, `ITrackable` is used because all shipment types need to provide a tracking status. An abstract class is better when related classes need to share common data, validation, or code.

### c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

No. A class can inherit from only one class, whether that class is abstract or not. However, a class can implement multiple interfaces at the same time.
