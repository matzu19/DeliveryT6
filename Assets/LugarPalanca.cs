using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LugarPalanca : MonoBehaviour
{
    [SerializeField] private SelectionManager selected;
    [SerializeField] private PuzzleManager item;
    [SerializeField] private Pickable lista;
    [SerializeField] private GameObject PressClick, palanca;
    [SerializeField] private Collider holder;

    private bool EsElLugar;

    private void Update()
    {
        if (EsElLugar)
        {
            PressClick.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine(ColocarPalanca());
                holder.enabled = !holder.enabled;
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
    IEnumerator ColocarPalanca()
    {
        PressClick.SetActive(false);
        palanca.SetActive(true);
        lista.RemovePalanca(item.SelectedItem());
        yield return null;
    }
}