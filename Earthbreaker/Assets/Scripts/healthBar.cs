using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{

    public Slider slider;

    public void setMaxHealth(long health){
        slider.maxValue = health;
        slider.value = health;
    }

    public void setHealth(long health){
        slider.value = health;
    }
}
