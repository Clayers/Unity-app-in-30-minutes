using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    int BreadCost = 25;
    int MeetCost = 50;
    int SoupCost = 100;
    Hp Hp = new Hp();

    public void BuyBread()
    {
        
        if (DataHuman.Human.GetMoney() >= BreadCost)
        {

            if (DataHuman.Human.GetHunger() != 100)
            {
                DataHuman.Human.SetMoney(DataHuman.Human.GetMoney() - BreadCost);
                if (DataHuman.Human.GetHunger() > 75)
                {
                    DataHuman.Human.SetHunger(100);
                }
                else
                {
                    DataHuman.Human.SetHunger(DataHuman.Human.GetHunger() + BreadCost);
                }

            }
        }
        Hp.Actions();

    }
    public void BuyMeet()
    {
       
        if (DataHuman.Human.GetMoney() >= MeetCost)
        {

            if (DataHuman.Human.GetHunger() != 100)
            {
                DataHuman.Human.SetMoney(DataHuman.Human.GetMoney() - MeetCost);
                if (DataHuman.Human.GetHunger() > 50)
                {
                    DataHuman.Human.SetHunger(100);
                }
                else
                {
                    DataHuman.Human.SetHunger(DataHuman.Human.GetHunger() + MeetCost);
                }
            }
        }
        Hp.Actions();

    }
    public void BuySoup()
    {
     
        if (DataHuman.Human.GetMoney()>=SoupCost)
        {


            if (DataHuman.Human.GetHunger() != 100)
            {
                DataHuman.Human.SetMoney(DataHuman.Human.GetMoney() - SoupCost);

                DataHuman.Human.SetHunger(100);

            }
        }
        Hp.Actions();
    }
    
}
