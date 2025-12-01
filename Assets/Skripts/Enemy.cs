using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 3f;
    public void Die()
    {
        health--;
        if (health == 0)
        {
           Destroy(gameObject); 
        }
        
    }
}
