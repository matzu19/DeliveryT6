using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gloves : MonoBehaviour
{
    [SerializeField] private Pickable recogible;
    [SerializeField] private bool guantesOn;

    public void RecogerObjeto()
    {
        guantesOn = true;
        recogible.AddObject("Gloves");
    }
    public bool guantesPuesto()
    {
        return guantesOn;
    }
}