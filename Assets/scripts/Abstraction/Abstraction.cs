using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abstraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dog d=new Dog();
        d.AnimalSound();
    }

}
