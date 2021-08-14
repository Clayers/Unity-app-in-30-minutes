using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    
    public Text EnergyText;
    public Text HpText;
    public Text HungerText;
    public Text MoneyText;
    NewGame NewGame = new NewGame();
    
    void Start()
    {
        Debug.Log("Старт");
    
        NewGame.New();
        Debug.Log("Energy:" + DataHuman.Human.GetEnergy().ToString() + "/100");

    }
    void Update()
    {
        EnergyText.text = "Energy:"+ DataHuman.Human.GetEnergy().ToString()+"/100";
        HpText.text = "Hp:"+ DataHuman.Human.GetHp().ToString() + "/100";
        HungerText.text = "Hunger"+ DataHuman.Human.GetHunger().ToString() + "/100";
        MoneyText.text = DataHuman.Human.GetMoney().ToString() + "$";
    }

}
