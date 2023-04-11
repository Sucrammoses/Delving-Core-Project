using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGlobalHealth : MonoBehaviour
{

    public float currentHealth;
    public float maxHealth = 100;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damagePoints)
    {

        currentHealth -= damagePoints;

    }

}
