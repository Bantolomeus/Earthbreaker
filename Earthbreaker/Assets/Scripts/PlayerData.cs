using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public long attack;
    public long attackSpeed;
    public long money;

    public PlayerData(long attack, long attackSpeed, long money) {
        this.attack = attack;
        this.attackSpeed = attackSpeed;
        this.money = money;
    }

    public override string ToString(){
        return $"attack is {attack}, attackSpeed is at {attackSpeed} and your money is currently {money}";
    }
}
