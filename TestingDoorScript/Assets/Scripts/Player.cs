using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public TextMeshProUGUI fragmentsText;


    private int fragments;

    public HealthBar healthBar;

    void Start()
    {
        fragments = 0;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        SetCountText();
    }

    void Update()
    {
        if(fragments == 10)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void SetCountText()
    {
        fragmentsText.text = "Fragments: " + fragments.ToString();
    }

    public void FragmentPickup()
    {
        fragments = fragments + 1;
        SetCountText();
    }
}
