using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screw : MonoBehaviour
{
    [SerializeField] private Pickable recogible;
    [SerializeField] private AudioSource pickAudio;

    public void RecogerObjeto()
    {
        pickAudio.Play();
        recogible.AddObject("Screw");
    }
}