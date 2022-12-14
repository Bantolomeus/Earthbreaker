using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public long attack;
    public long attackSpeed;
    public long attackWaiter;
    public long money;

    public Enemy enemy;
    public JsonSaving jsonSaving;
    private PlayerData savedData;

    void Start(){
        savedData = jsonSaving.loadData();

        if(savedData != null){
            attack = savedData.attack;
            attackSpeed = savedData.attackSpeed;
            money = savedData.money;
        } else {
            attack = 1;
            attackSpeed = 1;
            money = 1;
        }

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

    public PlayerData getHeroData(){
        return new PlayerData(attack, attackSpeed, money);
    }

    public void setPlayerData(long attack, long attackSpeed, long money){
        this.attack = attack;
        this.attackSpeed = attackSpeed;
        this.money = money;
    }

}
