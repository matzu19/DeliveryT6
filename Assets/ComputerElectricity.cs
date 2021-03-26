using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerElectricity : MonoBehaviour , IAction
{
    bool electricity;
    public SwitchLever swithcOne, swithcTwo, swithcThree;
/*
    [SerializeField] private GameObject PressE, canvasPuzzle, canvasGeneral, reticula, camara; //Santiago
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;*/

    // Start is called before the first frame update
    void Start()
    {
        electricity = false;
        
    }
    //Método que cambia la electricidad a encendida. Debe de ir a los scripts de las palancas y activar su variable electricidad
  
        

    public void Activate()
    {
        electricity = !electricity;
        if (electricity)
        {
            swithcOne.stream = true;
            swithcTwo.stream = true;
            swithcThree.stream = true;
            Debug.Log("Pc Stream Activated");
        }
        else
        {
            swithcOne.stream = false;
            swithcTwo.stream = false;
            swithcThree.stream = false;
            Debug.Log("Pc Stream deactivated");

        }
    }
}
