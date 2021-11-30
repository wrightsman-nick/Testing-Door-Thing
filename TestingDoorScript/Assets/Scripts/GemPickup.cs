using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemPickup : MonoBehaviour
{

    public GameObject gemObject;
    public GameObject player;
    public Player playerHealth;


    bool m_isPlayerAtGem;


    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            m_isPlayerAtGem = true;
        }
    }

    void Update ()
    {
        if (m_isPlayerAtGem)
        {
            playerHealth.TakeDamage(10);
            gemObject.SetActive(false);
        }
    }
}
