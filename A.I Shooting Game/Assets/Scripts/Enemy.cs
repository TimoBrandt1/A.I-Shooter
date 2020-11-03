using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int startingHealth = 100;
    private int currentHealth;

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        currentHealth = startingHealth;
    }

    private void GetShot(int damage)
    {
        InflictDamage(damage);
    }

    private void InflictDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Respawn();
    }

    private void Respawn()
    {
        currentHealth = startingHealth;
        transform.position = startPos;
    }

}
