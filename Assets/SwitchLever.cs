using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : MonoBehaviour, IAction
{
    [SerializeField]
    private int n;
    public bool stream;
    
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
        Debug.Log("el estado de la corriente es " + stream);
    }
}
