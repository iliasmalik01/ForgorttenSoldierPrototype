using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthdepletion : MonoBehaviour
{
    public AttributesManager playerHealth;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void Update()
    {
        
        if (playerHealth.gethealth() <= 0)
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            playerHealth.Heal();
            playerHealth.Heal();
            playerHealth.Heal();
            playerHealth.Heal();
            playerHealth.Heal();
        }
    }
}
