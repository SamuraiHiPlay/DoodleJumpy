using System;
using JetBrains.Annotations;
using UnityEngine;

public class Poof : MonoBehaviour
{
    public float destroy = 0.5f;
    
    private bool isTrigger = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isTrigger && collision.gameObject.CompareTag("Player"))
        {
            isTrigger = true;
            Destroy(gameObject, destroy);
        }
    }
}
