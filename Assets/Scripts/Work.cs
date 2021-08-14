using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    Hp Hp = new Hp();
    public void Worked()
    {
      
        if (DataHuman.Human.GetEnergy()>0)
        {
            DataHuman.Human.SetMoney(DataHuman.Human.GetMoney() + 25);
            DataHuman.Human.SetEnergy(DataHuman.Human.GetEnergy() - 10);

            Hp.Actions();
        }
    }

}
