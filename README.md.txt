Definition - Factory patterns are creational design patterns that provide the best way to create objects.
In factory patterns, we make the object of the class without exposing the creation/instantiation logic 
to the user who wants to make the object and then return the newly created object using the common 
interface inherited by the class.

Components 
Product Interface / Abstract Product: This represents the interface or abstract class defining the 
methods that concrete products must implement. Our example is the Loan interface.
Concrete Products: These classes implement the Product interface or extend the abstract class. 
They are the actual objects that the factory will create. Our examples are the HomeLoan, PersonalLoan,
and Vehicle classes.
Creator or Factory: This class provides the factory method to return a specific concrete product. 
Our example is the LoanFactory class.
Client: The class that consumes the actual product objects. Our example, it is the Program class 
Main method.

Advantages of the Factory pattern
1) Separates creation logic from client code, improving flexibility.
2) New product types can be added easily.
3) Simplifies unit testing by allowing mock product creation.
4) Centralizes object creation logic across the application.
5) Hides specific product classes from clients, reducing dependency.

Disadvantages of the Factory pattern
1) Adds more classes and interfaces, which can complicate maintenance.
2) Slight performance impacts due to polymorphism.
3) Concrete creators are linked to their products.
4) Clients need knowledge of specific subclasses.
5) Difficult to test.

