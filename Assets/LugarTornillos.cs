using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LugarTornillos : MonoBehaviour
{
    [SerializeField] private SelectionManager selected;
    [SerializeField] private GameObject PressClick;

    private bool EsElLugar;

    private void Update()
    {
        if (EsElLugar)
        {
            PressClick.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Coloca Tornillo");
            }
        }
    }
    public bool EsElLugarCorrecto()
    {
        return EsElLugar = true;
    }
    public bool NoEsElLugarCorrecto()
    {
        PressClick.SetActive(false);
        return EsElLugar = false; ;
    }
}