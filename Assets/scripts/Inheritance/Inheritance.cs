using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    //public MeeleeEnemy meleeEnemy;
    //public RangedEnemy rangedEnemy;

    void Start()
    {
        MeeleeEnemy meleeEnemy=new MeeleeEnemy();
        RangedEnemy rangedEnemy=new RangedEnemy();

        // Accessing common properties and methods from base class
        meleeEnemy.enemyName = "Orc";
        meleeEnemy.health = 100;
        meleeEnemy.movementSpeed = 5f;
        meleeEnemy.Attack(); // Calls overridden Attack method in MeleeEnemy

        rangedEnemy.enemyName = "Archer";
        rangedEnemy.health = 80;
        rangedEnemy.movementSpeed = 3f;
        rangedEnemy.Attack(); // Calls overridden Attack method in RangedEnemy
    }
}
