using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : MonoBehaviour, IAction
{
    [SerializeField]
    private int n;
    public bool stream;


   
    public void Activate()
    {
        Debug.Log("el estado de la corriente es " + stream);
    }
}
