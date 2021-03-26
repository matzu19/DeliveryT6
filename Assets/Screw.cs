using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screw : MonoBehaviour
{
    [SerializeField] private Pickable recogible;

    public void RecogerObjeto()
    {
        recogible.AddObject("Screw");
    }
}