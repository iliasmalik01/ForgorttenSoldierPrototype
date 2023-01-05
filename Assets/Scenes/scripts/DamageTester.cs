using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager BigEnemy;
    
    // Update is called once per frame
    private void Update()
    {
        //Deal player damage to big enemy
        if(Input.GetKeyDown(KeyCode.F9))
        {
            playerAtm.DealDamage(BigEnemy.gameObject);
        }

        //Deal enemy damage to player health
        if(Input.GetKeyDown(KeyCode.F12))
        {
            BigEnemy.DealDamage(playerAtm.gameObject);
        }
        
        //Heals Player
        if(Input.GetKeyDown(KeyCode.F10))
        {
            playerAtm.Heal();
        }
    }
}
