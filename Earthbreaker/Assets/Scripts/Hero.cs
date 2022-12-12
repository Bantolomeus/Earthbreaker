using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public long attack = 1;
    public long attackSpeed = 1;
    public long attackWaiter = 0;

    public Enemy enemy;

    void Start(){
        attackWaiter = 0;
    }

    void Update(){
        if (attackWaiter == 600) {
            attackWaiter = 0;
            doDamage(attack, enemy);
        } else {
            attackWaiter ++;
        }
    }

    public void doDamage(long attack, Enemy enemy) {
        enemy.takeDamage(attack);
    }
}
