using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField]private PuzzleManager puzzle;
    [SerializeField] public Material highlightMaterial, defaultMaterial;

    public void OnDeselect(Transform selection)
    {
        var selectionMaterial = selection.GetComponent<Renderer>();

        if (selectionMaterial != null)
        {
            selectionMaterial.material = defaultMaterial;
            puzzle.PuzzleIdentifier(null);
        }
    }

    public void OnSelect(Transform selection)
    {
        var selectionMaterial = selection.GetComponent<Renderer>();
        if (selectionMaterial != null)
        {
            selectionMaterial.material = highlightMaterial;
            puzzle.PuzzleIdentifier(selection.gameObject.name);
        }
    }
}
