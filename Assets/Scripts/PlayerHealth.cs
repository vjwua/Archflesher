using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float healthPoints = 100f;
    DeathHandler deathHandler;

    void Start()
    {
        deathHandler = FindObjectOfType<DeathHandler>();
    }
    public void TakeDamage(float damage)
    {
        healthPoints -= damage;
        if (healthPoints < 0) deathHandler.HandleDeath();
    }
}
