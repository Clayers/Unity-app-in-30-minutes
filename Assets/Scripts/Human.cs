using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{




    public int Energy;
    public int Hunger;
    public int Money;
    public int Hp;

    public void HumanData(int energy, int hunger, int money, int hp)
    {
        Energy = energy;
        Hunger = hunger;
        Money = money;
        Hp = hp;
    }
    public int GetEnergy() 
    {
        return Energy;
    }
    public void SetEnergy(int Energy)
    {
        this.Energy =Energy;
    }
    public int GetHunger()
    {
        return Hunger;
    }
    public void SetHunger(int Hunger)
    {
        this.Hunger = Hunger;
    }
    public int GetMoney()
    {
        return Money;
    }
    public void SetMoney(int Money)
    {
        this.Money = Money;
    }
    public int GetHp()
    {
        return Hp;
    }
    public void SetHp(int Hp)
    {
        this.Hp = Hp;
    }
}
