/*
 * Test Your Knowledge:
 * -- 1
 * 1. String
 * 2. Float 
 * 3. Byte
 * 4. String
 * 5. double
 * 6. String or long
 * 7. float or double
 * 8. float
 * 9. long
 * 10. String to represent a big number
 * 11. int
 * 
 * -- 2
 * pass by value means during execution the object data is copied for
 * the variable used in the method (aka two different variables with the same
 * data are created). pass by reference is the opposite, where the data being
 * passed in is the same data being used by the method.
 * boxing is the process of a value being wrapped up in an object, and unboxing
 * is casting that value out from the object (disassociating them).
 * 
 * 
 *-- 3
 *Managed resources are those that are handled by the .NET system, and does not need to be
 *directly managed. an example of this is a regular int, where the deallocation is
 *done by the .NET system. Unmanaged resources are those that are not directly handled,
 *such as Files (closing Files) and server connections.
 *
 *-- 4
 *the purpose of the garbage collector is to identify and free memory allocated by the system.
 *dynamically allocated memory is not collected by this, and not freeing this memory
 *will cause a memory leak.
 *
 */

/*
Console.Write("Tell me your favorite color, and I will tell your fortune: ");
string color = Console.ReadLine();
Console.WriteLine($"The future is very \"{color}\" for you!");
*/

/*
 * Controlling Flow and Coverting Types
 * 
 * 1. get thrown a dividebyzeroexception
 * 2. get thrown a dividebyzeroexception
 * 3. it loops back to the minimum value
 * 4. x - y++ increments y after the subtracation, while x - ++y increments y before
 *    the operation
 * 5. 'break' break out of a loop, 'continue' continues the loop (does its endloop stuff, if any, continues to next run of loop)
 *    'return' returns from a method regardless of where you are in execution
 * 6. initalize (left) continue while (middle) stop when true (right). none are required, only two semicolons
 * 7. = is the assignment operator, == tests if two values are the same or not
 * 8. yes
 * 9. _ means default
 * 10. IEnumerable
 */

/*
 * Test Your Knowledge
 * 1. since strings are immutable, you should use strings when you do not need to modify, or "build" the string as you go.
 *    you should use stringbuilder when you need to dynamically build a string.
 * 2. The Array class, defined in system
 * 3. Array.sort() sorts arrays based on it's natural ordering
 * 4. using the length property
 * 5. no, strongly typed language
 * 6. copyto copies the contents of an array into another existing array, clone returns a new array. both return shallow copies
 */

using Homework;

Problems.reverseWords();





