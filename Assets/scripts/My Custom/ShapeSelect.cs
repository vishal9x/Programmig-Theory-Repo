using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class ShapeSelect : MonoBehaviour
{
    // Properties
    public string Name { get; set; }
    public Color Color { get; set; }

    // Constructor
    public ShapeSelect(string name, Color color)
    {
        Name = name;
        Color = color;
    }

    // Method to be overridden
    public virtual void DisplayText()
    {
        Debug.Log("This is a shape.");
    }
}

public class CircleSelect : ShapeSelect
{
    public float Radius { get; private set; }

    public CircleSelect(string name, Color color, float radius) : base(name, color)
    {
        Radius = radius;
    }

    public override void DisplayText()
    {
        Debug.Log($"This is a circle named {Name} with radius {Radius} units.");
    }
}

public class SquareSelect : ShapeSelect
{
    public float SideLength { get; private set; }

    public SquareSelect(string name, Color color, float sideLength) : base(name, color)
    {
        SideLength = sideLength;
    }

    public override void DisplayText()
    {
        Debug.Log($"This is a square named {Name} with side length {SideLength} units.");
    }
}

public class TriangleSelect : ShapeSelect
{
    public float BaseLength { get; private set; }
    public float Height { get; private set; }

    public TriangleSelect(string name, Color color, float baseLength, float height) : base(name, color)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public override void DisplayText()
    {
        Debug.Log($"This is a triangle named {Name} with base {BaseLength} units and height {Height} units.");
    }
}
