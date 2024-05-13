using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 10; // Maximum health of the pig
    public int currentHealth; // Current health of the pig
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Reduce health by the damage amount
        if (currentHealth <= 0)
        {
            Die(); // Call Die function if health goes to zero or below
        }
    }
    
    private void Die()
    {
        Debug.Log("Pig died");
        // Destroy the pig GameObject
        Destroy(gameObject);
    }
    
    // Resets the pig's health to maximum
    public void ResetHealth()
    {
        currentHealth = maxHealth; // Reset current health to maximum health
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
