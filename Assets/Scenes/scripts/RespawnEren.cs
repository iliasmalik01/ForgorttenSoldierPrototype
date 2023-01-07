using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEren : MonoBehaviour
{
    public AttributesManager playerHealth;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
