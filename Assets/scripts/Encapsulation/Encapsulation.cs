using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulation : MonoBehaviour
{
    // Private fields encapsulated with public properties
    private int health; // Example private field

    // Public property for health (encapsulation)
    public int Health
    {
        get { return health; }
        set
        {
            // Health should not be negative
            health = Mathf.Max(value, 0); // Ensure health is non-negative
            if (health <= 0)
            {
                Die(); // Example method call when health reaches zero
            }
        }
    }

    // Example private method encapsulated
    private void Die()
    {
        Debug.Log("Player died!");
        // Additional logic for handling player death
    }

    // Public method for the player to take damage
    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount; // Example of encapsulated behavior
    }

    // Example public method for healing the player
    public void Heal(int healAmount)
    {
        Health += healAmount; // Example of encapsulated behavior
    }

    // Example Start method (unity lifecycle method)
    private void Start()
    {
        Health = 100; // Example initialization
        TakeDamage(20); // Player takes 20 damage
        Heal(30); // Player heals 30 health points
    }
}
