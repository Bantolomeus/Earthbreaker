using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextReplacer : MonoBehaviour
{

    public Hero hero;
    public Enemy enemy;

    [SerializeField]
    private TMP_Text attackTitle;

    [SerializeField]
    private TMP_Text defenseTitle;


    // Start is called before the first frame update
    void Start()
    {
        // change text field above hero to show his attack value
        long attack = hero.attack;
        attackTitle.text = "Attack: " + attack.ToString();

        // change text field above the enemy to show his defense value
        long defense = enemy.defense;
        defenseTitle.text = "Defense: " + defense.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
