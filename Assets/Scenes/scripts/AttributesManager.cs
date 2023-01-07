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

    public Animator anima;

    public void TakeDamage(int amount)
    {
        anima.SetTrigger("Hit");
        health -= amount;
        healthBar.SetHealth(health);
        Vector3 randomness = new Vector3(Random.Range(0f, 0.25f), Random.Range(0f, 0.25f), Random.Range(0f, 0.25f));
        DamagePopUpGenerator.current.CreatePopUp(transform.position + randomness, amount.ToString(), Color.red);
    }

    public void Heal()
    {
        Vector3 randomness = new Vector3(Random.Range(0f, 0.25f), Random.Range(0f, 0.25f), Random.Range(0f, 0.25f));
        if (health == 100)
        {
            DamagePopUpGenerator.current.CreatePopUp(transform.position + randomness, "100", Color.blue);
        }

        if (health <= 80)
        {
            health += 20;
            DamagePopUpGenerator.current.CreatePopUp(transform.position + randomness, "+20", Color.green);
        }

        else if (health >= 80)
        {
            DamagePopUpGenerator.current.CreatePopUp(transform.position + randomness, "+"+(100-health).ToString(), Color.yellow);
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

    public int gethealth()
    {
        return health;
    }

}
