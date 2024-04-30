using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int amountOfBullets = 7;

    public int getAmountOfBullets()
    {
        return amountOfBullets;
    }

    public void reduceAmountOfBullets()
    {
        amountOfBullets--;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
