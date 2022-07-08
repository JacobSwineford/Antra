/*
 * 1. public, private, protected, internal, protected internal, private protected
 * 2. readonly can only read variable, const cannot change, static one instance in memory
 * 3. method that runs when an object is constructed along with the new keyword
 * 4. part of a class can be defined somewhere else in the namespace
 * 5. convenient ways to group data elements together
 * 6. Defines a reference type that provdies a built in functionality for encapsulating data.
 * 7. Overloading: same method declaration, different params Overriding: use a subclasses version of a method instead of the 
 *    superclass version
 * 8. A property is a field with the increased functionality of creating methosd that make it a property, such as
 *    getting and setting
 * 9. add a default value
 * 10. defines a type and methods to be implemented, while abstract classes can define methods to implement, and concrete methods / fields
 * 11. public 
 * 12: I guess? true
 * 13: true
 * 14: method hiding, false? a new method is used, so perhaps
 * 15: if they are defined, false
 * 16: true
 * 17: true
 * 18: false
 * 19: false (you can try, it won't work. has to be virtual)
 * 20: false
 * 21: true
 * 22: false
 * 23: true
 */

using Homework_3.Ball_Boys;

Ball[] balls = new Ball[10];
for (int i = 0; i < 10; i++)
{ 
    balls[i] = new Ball(5, new Color(100, 100, 100));
    while (balls[i].getSize() != 0)
    {
        balls[i].throwBall();
    }
    Console.WriteLine($"number of throws: {balls[i].getThrows()}");
}

