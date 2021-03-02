using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaciónEscenario : MonoBehaviour
{
    //este cósigo solo hace que rote el pbjeto al que se le asigne.
    //Pensado para ponerse en la cámara del Main menu

    public float VelRotacion;
    void Start()
    {
        
    }

    // Update is called once per frame
      void Update()
    {
        transform.Rotate(new Vector3(0,VelRotacion/100, 0));
    }
}
