using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candado : MonoBehaviour
{
    private bool puzzleActivo;
    public bool ActivarPuzzle()
    {
        return puzzleActivo = true;
    }
    public bool DesactivarPuzzle()
    {
        return puzzleActivo = false;
    }
}
