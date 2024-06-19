using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Common properties for all enemies
    public string enemyName;
    public int health;
    public float movementSpeed;

    // Common method for all enemies
    public virtual void Attack()
    {
        Debug.Log($"{enemyName} attacks!");
        // Default attack behavior
    }

    // Example method that can be overridden in derived classes
    public virtual void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Die(); // Example method call when health reaches zero
        }
    }

    protected virtual void Die()
    {
        Debug.Log($"{enemyName} died!");
        // Default death behavior
        Destroy(gameObject); // Destroy the game object
    }
}

public class MeeleeEnemy : Enemy
{
    // Additional properties specific to MeleeEnemy
    public int damage;

    // Override Attack method to implement specific behavior
    public override void Attack()
    {
        base.Attack(); // Call base method first if needed
        Debug.Log($"{enemyName} swings a melee attack!");
        // Specific attack behavior for MeleeEnemy
    }
}

public class RangedEnemy : Enemy
{
    // Additional properties specific to RangedEnemy
    public float attackRange;

    // Override Attack method to implement specific behavior
    public override void Attack()
    {
        base.Attack(); // Call base method first if needed
        Debug.Log($"{enemyName} shoots a ranged attack!");
        // Specific attack behavior for RangedEnemy
    }
}
