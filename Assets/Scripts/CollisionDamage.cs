using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public PigHealth pigHealth;
    
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a wooden block
        if (collision.gameObject.tag == "Wood_Block")
        {
            // Calculate damage based on the impact force
            int damage = Mathf.FloorToInt(collision.relativeVelocity.magnitude * 100);
            pigHealth.TakeDamage(damage);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
