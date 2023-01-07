using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnEnemy : MonoBehaviour
{
    public AttributesManager enemyAtm;
    
    void Update()
    {
        
        if (enemyAtm.gethealth() <= 0)
        {
            Destroy(gameObject);
        }
    }
}
