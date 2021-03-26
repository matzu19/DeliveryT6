using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gloves : MonoBehaviour
{
    [SerializeField] private Pickable recogible;

    public void RecogerObjeto()
    {
        recogible.AddObject("Gloves");
    }
}