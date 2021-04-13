using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : MonoBehaviour, IAction
{
    [SerializeField]
    private int n;
    public bool stream;
    public bool win;
    [SerializeField] private Gloves guantes;

    
    void condicion1()
    {

    }
    void condicion2()
    {

    }
    void condicion3()
    {

    }


    public void Activate()
    {
        if (stream && guantes.guantesPuesto())
        {
            this.transform.Rotate(0f, 0f, -80f);
            win = true;
        }
        else
        {
            //Feedback
        }
        
        Debug.Log("el estado de la corriente es " + stream);
    }
}
