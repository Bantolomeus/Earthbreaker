using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject damagePopup;
    private Vector3 vector = new Vector3(812, 401, 0);
    public long maxHealth = 10;
    public long currentHealth;
    public long defense = 0;
    
    public healthBar healthBar;

    void Start(){
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    void Update(){

    }

    public void takeDamage(long attack) {
        long damage = attack - defense;

        if (damage <= 0) {

        } else {
            currentHealth -= (damage);
            GameObject textPopup = Instantiate(damagePopup, vector, Quaternion.identity) as GameObject;
            textPopup.transform.GetChild(0).GetComponent<TextMesh>().text = damage.ToString();
            healthBar.setHealth(currentHealth);
        }
    }
}
