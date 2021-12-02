using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public TextMeshProUGUI fragmentsText;


    private int fragments;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        fragments = 0;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
    
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
