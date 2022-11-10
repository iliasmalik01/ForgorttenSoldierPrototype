using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  EnemyCollisions: MonoBehaviour
{
    public HealthBarSlider Healt;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            print("collison");
            Healt.SetMaxHealth(100);
            Healt.SetHealth(5);
        }
    }
}
