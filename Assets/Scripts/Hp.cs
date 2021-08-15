using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    NewGame NewGame = new NewGame();
    public void Actions()
    {
       
        if (DataHuman.Human.GetEnergy() <= 0 || DataHuman.Human.GetHunger()<=0)
        {
            DataHuman.Human.SetHp(DataHuman.Human.GetHp() - 10);           
        }
        if (DataHuman.Human.GetEnergy() > 0 && DataHuman.Human.GetHunger() > 0 && DataHuman.Human.GetHp()<100)
        {
            DataHuman.Human.SetHp(DataHuman.Human.GetHp() + 5);
        }
        if (DataHuman.Human.GetHunger() > 10)
        {
            DataHuman.Human.SetHunger(DataHuman.Human.GetHunger() - 10);
        }
        else 
        {
            DataHuman.Human.SetHunger(0);
        }
        if (DataHuman.Human.GetHp()<0)
        {
            NewGame.New();
        }

    }
}
