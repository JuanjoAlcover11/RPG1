using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public int expWhenDefeated;


    void Start()
    {
        UpdateMaxHealth(maxHealth);
    }

    public void DamageCharacter(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            /*if (gameObject.tag.Equals("Enemy"))
            { 
                GameObject.Find("Player").GetComponent<CharacterStats>.
                 AddExperience(expWhenDefeated);
            }*/

            gameObject.SetActive(false);
            }
        }

        public void UpdateMaxHealth(int newMaxHealth)
        {
            maxHealth = newMaxHealth;
            currentHealth = maxHealth;
        }
    } 


