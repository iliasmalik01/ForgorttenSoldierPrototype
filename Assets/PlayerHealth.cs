using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerHealth : MonoBehaviour
{
    public int Maxhealth=100;
    public int health;

    public HealthBarSlider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = Maxhealth;
        healthBar.SetMaxHealth(Maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }
    void TakeDamage(int demage)
    {
        health -= demage;
        healthBar.SetHealth(health);
    }
}
