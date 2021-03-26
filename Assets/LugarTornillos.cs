using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LugarTornillos : MonoBehaviour
{
    [SerializeField] private SelectionManager selected;
    [SerializeField] private PuzzleManager item;
    [SerializeField] private Pickable lista;
    [SerializeField] private GameObject PressClick, tornillo;
    [SerializeField] private Collider holder, palanca;

    private bool EsElLugar;

    private void Update()
    {

        if (EsElLugar)
        {

            PressClick.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                palanca.enabled = true;
                holder.enabled = !holder.enabled;
                StartCoroutine(ColocarTornillo());
                Debug.Log("puesto en el lugar");

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
    IEnumerator ColocarTornillo()
    {
        PressClick.SetActive(false);
        tornillo.SetActive(true);
        lista.RemoveTornillo(item.SelectedItem());
        yield return null;
    }
}