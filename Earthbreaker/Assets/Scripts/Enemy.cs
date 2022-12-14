using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public long maxHealth = 10;
    public long currentHealth;
    public long defense = 0;
    // long demoDamage = 3;
    

    public healthBar healthBar;

    void Start(){
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    void Update(){
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     takeDamage(demoDamage);
        // }
    }

    public void takeDamage(long attack) {
        if (attack - defense <= 0) {

        } else {
            currentHealth -= (attack - defense);
            healthBar.setHealth(currentHealth);
        }
    }
}
