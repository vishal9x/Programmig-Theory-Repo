using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private ShapeSelect shape;

    void Start()
    {
        // Assuming each shape has its own unique properties
        if (gameObject.CompareTag("Circle"))
        {
            shape = new CircleSelect("MyCircle", Color.blue, 3.0f);
        }
        else if (gameObject.CompareTag("Square"))
        {
            shape = new SquareSelect("MySquare", Color.red, 2.5f);
        }
        else if (gameObject.CompareTag("Triangle"))
        {
            shape = new TriangleSelect("MyTriangle", Color.green, 4.0f, 3.0f);
        }
    }

    void OnMouseDown()
    {
        shape.DisplayText();
    }
}

/*
 1. Encapsulation:
Encapsulation is the bundling of data (properties) and methods (functions) that operate on the data into a single unit (class). It helps in hiding the internal state of an object from the outside world and controlling access to it.

Example in the Code:

Encapsulation is demonstrated through the use of properties (Name, Color, Radius, SideLength, BaseLength, Height) in each shape class (Circle, Square, Triangle). These properties are private (private set;) and accessed via public getters and setters (get; set;), allowing controlled access to the internal state of each shape.
2. Inheritance:
Inheritance is the mechanism where one class (derived class) inherits the properties and behaviors (methods) of another class (base class). It promotes code reusability and allows derived classes to extend or modify the behavior of the base class.

Example in the Code:

Inheritance is demonstrated by the relationship between the Shape class (base class) and the shape classes (Circle, Square, Triangle) that inherit from it. Each shape class inherits the Name and Color properties and overrides the DisplayText() method with its own specific implementation.
3. Polymorphism:
Polymorphism allows objects of different types to be treated as objects of a common base type. It enables the same method to behave differently based on the object it is called upon. Polymorphism is achieved through method overriding and method overloading.

Example in the Code:

Polymorphism is demonstrated through the DisplayText() method:
Each shape class (Circle, Square, Triangle) overrides the DisplayText() method from the base class (Shape) with its own implementation.
When DisplayText() is called on a Shape reference, the specific implementation corresponding to the actual type of the object (circle, square, triangle) is executed dynamically at runtime.
4. Abstraction:
Abstraction refers to the process of hiding the complex implementation details and showing only the essential features of the object. It helps in reducing complexity and improving efficiency by providing a simplified view of objects.

Example in the Code:

Abstraction is demonstrated through the separation of concerns and use of higher-level methods:
The Shape class provides a high-level abstraction for common properties (Name, Color) and behavior (DisplayText()).
Each shape class (Circle, Square, Triangle) provides specific implementations for its unique attributes (Radius, SideLength, BaseLength, Height) and specific behaviors (DisplayText()).
Summary:
The provided Unity3D C# code example effectively demonstrates all four OOP principles:

Encapsulation: Properties with getters and setters encapsulate the state of each shape.
Inheritance: Shape classes inherit common properties and behaviors from the base Shape class.
Polymorphism: Method overriding (DisplayText()) allows different shapes to exhibit different behaviors through a common interface.
Abstraction: The code structure hides internal details and provides a simplified interface (Shape class) for interacting with shapes.
By adhering to these principles, the code achieves maintainability, extensibility, and flexibility in representing and interacting with different types of shapes within a Unity3D environment.
 
 */