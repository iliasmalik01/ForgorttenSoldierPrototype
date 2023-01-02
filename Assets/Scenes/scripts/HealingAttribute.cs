using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingAttribute : MonoBehaviour
{
    public AttributesManager playerAtm;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sword"))
        {
            playerAtm.Heal();
            DestroyHealer();
        }
    }

    private void DestroyHealer()
    {
        Destroy(gameObject);
    }
}
