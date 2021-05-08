using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string puzzleNameIs, sName;
    [SerializeField] private PalancaFinal pFinal;
    [SerializeField] private Rompecabezas rompecabezas;
    [SerializeField] private Candado candado;
    [SerializeField] private LugarTornillos lugarTornillos;
    [SerializeField] private LugarPalanca lugarPalanca;
    [SerializeField] private InventoryManager InvMgr;
    [SerializeField] private InventoryScroll InvScl;
    [SerializeField] private GameObject camara1, camara2, camara3, pressE;

    private void Update()
    {
        if(camara1.activeInHierarchy || camara2.activeInHierarchy || camara3.activeInHierarchy)
        {
            pressE.SetActive(false);
        }
        switch (puzzleNameIs)
        {
            case "Rompecabezas":
                rompecabezas.ActivarPuzzle();
                break;
            case "Candado":
                candado.ActivarPuzzle();
                break;
            case "P Screw":
                SelectedItem();
                if (puzzleNameIs == "P " + sName)
                {
                    lugarTornillos.EsElLugarCorrecto();
                }
                else break;
                break;
            case "P Lever":
                SelectedItem();
                if (puzzleNameIs == "P " + sName)
                {
                    lugarPalanca.EsElLugarCorrecto();
                }
                else break;
                break;
            case null:
                lugarPalanca.NoEsElLugarCorrecto();
                lugarTornillos.NoEsElLugarCorrecto();
                rompecabezas.DesactivarPuzzle();
                candado.DesactivarPuzzle();
                break;
        }
    }


    public string PuzzleIdentifier(string puzzleName)
    {
        return puzzleNameIs = puzzleName;
    }
    public string SelectedItem()
    {
        sName = InvMgr.Item(InvScl.SelectorPosition());
        return sName;
    }
}
