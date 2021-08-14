using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    Hp Hp = new Hp();
    public void Dream()
    {
       
        DataHuman.Human.SetEnergy(100);
        Hp.Actions();
    }
    
}
