using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string puzzleNameIs, sName;
    [SerializeField] private PalancaFinal pFinal;
    [SerializeField] private Rompecabezas rompecabezas;
    [SerializeField] private Candado candado;
    [SerializeField] private Computadora computadora;
    [SerializeField] private Interruptores interruptores;
    [SerializeField] private LugarTornillos lugarTornillos;
    [SerializeField] private LugarPalanca lugarPalanca;
    [SerializeField] private InventoryManager InvMgr;
    [SerializeField] private InventoryScroll InvScl;

    private void FixedUpdate()
    {
        switch (puzzleNameIs)
        {
            case "Rompecabezas":
                rompecabezas.ActivarPuzzle();
                break;
            case "Candado":
                candado.ActivarPuzzle();
                break;
            case "Computadora":
                computadora.ActivarPuzzle();
                break;
            case "Interruptores":
                interruptores.ActivarPuzzle();
                break;
            case "P Screw":
                SelectedItem();
                if (puzzleNameIs == "P " + sName)
                {
                    lugarTornillos.EsElLugarCorrecto();
                }
                break;
            case "P Lever":
                SelectedItem();
                if (puzzleNameIs == "P " + sName)
                {
                    lugarPalanca.EsElLugarCorrecto();
                }
                break;
            case "Lever 2":
                pFinal.ActivarPalancaFinal();
                break;
            case null:
                pFinal.DesactivarPalancaFinal();
                lugarPalanca.NoEsElLugarCorrecto();
                lugarTornillos.NoEsElLugarCorrecto();
                rompecabezas.DesactivarPuzzle();
                candado.DesactivarPuzzle();
                computadora.DesactivarPuzzle();
                interruptores.DesactivarPuzzle();
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
