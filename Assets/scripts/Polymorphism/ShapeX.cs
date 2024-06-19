using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeX : MonoBehaviour
{
    public virtual void Draw()
    {
        Debug.Log("Drawing a shape");
    }
}

public class Circle : ShapeX
{
    public override void Draw()
    {
        Debug.Log("Drawing a circle");
    }
}

public class Square : ShapeX
{
    public override void Draw()
    {
        Debug.Log("Drawing a square");
    }
}
