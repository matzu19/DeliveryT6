using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gloves : MonoBehaviour
{
    [SerializeField] private Pickable recogible;
    [SerializeField] private bool guantesOn;
    [SerializeField] private AudioSource pickAudio;

    public void RecogerObjeto()
    {
        pickAudio.Play();
        guantesOn = true;
        recogible.AddObject("Gloves");
    }
    public bool guantesPuesto()
    {
        return guantesOn;
    }
}