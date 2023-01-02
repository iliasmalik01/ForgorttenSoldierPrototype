using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributesManager : MonoBehaviour
{
    public int MaxHealth;
    public int health;
    public int attack;

    public HealthBar healthBar;

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthBar.SetHealth(health);
        Vector3 randomness = new Vector3(Random.Range(0f, 0.25f), Random.Range(0f, 0.25f), Random.Range(0f, 0.25f));
        DamagePopUpGenerator.current.CreatePopUp(transform.position + randomness, amount.ToString(), Color.yellow);
    }

    public void Heal()
    {
        if (health != 100)
        {
            health += 20;
        }

        else if (health > 80)
        {
            health = 100;
        }

        healthBar.SetHealth(health);
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if(atm != null)
        {
            atm.TakeDamage(attack);
        }
    }

    public void Despawn()
    {
        
    }

    public int gethealth()
    {
        return health;
    }
}
