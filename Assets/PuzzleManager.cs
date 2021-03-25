using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    private string puzzleNameIs;
    [SerializeField] private Rompecabezas rompecabezas;
    [SerializeField] private Candado candado;
    [SerializeField] private Computadora computadora;
    [SerializeField] private Interruptores interruptores;

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
            case null:
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
}
