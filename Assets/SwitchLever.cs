using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : MonoBehaviour, IAction
{
    [SerializeField]
    private int n;
    public bool stream;
    public bool win;

    
    void condicion1()
    {
        //if (stream)
            //activar animación
    }
    void condicion2()
    {

    }
    void condicion3()
    {

    }


    public void Activate()
    {
        if (stream)
        {
            this.transform.Rotate(0f, 0f, -80f);
            win = true;
        }
        
        Debug.Log("el estado de la corriente es " + stream);
    }
}
