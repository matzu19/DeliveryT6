using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private string selectableTag = "Selectable";
    private ISelectionResponse _selectionResponse;
    private HighlightSelectionResponse highlight;
    private Material defaultMaterial;
    private Transform _selection;
    

    private void Awake()
    {
        _selectionResponse = GetComponent<ISelectionResponse>();
        highlight = GetComponent<HighlightSelectionResponse>();
    }

    private void Update()
    {
        if (_selection != null)
        {
            _selectionResponse.OnDeselect(_selection);//Object in Deselection
        }
        _selection = null;

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1.5f))
        {
            var selection = hit.transform;
            highlight.defaultMaterial = selection.GetComponent<Renderer>().material;
            if (selection.CompareTag(selectableTag)) _selection = selection;
        }//Raycast Region

        if (_selection != null)
        {
            _selectionResponse.OnSelect(_selection);//Object in selection
        }
    }
}
