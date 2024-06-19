using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    void Start()
    {
        ShapeX shape1 = new Circle();//Dynamic Binding: The type of object that the base class reference points to (Shape in this case) determines which version of the Draw() method is called at runtime. This is known as dynamic dispatch or late binding, which is a key feature of polymorphism.
        ShapeX shape2 = new Square();

        shape1.Draw();  // Output: "Drawing a circle"
        shape2.Draw();  // Output: "Drawing a square"
    }
}
