using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private string selectableTag = "Selectable", UnlockTag = "Lock";
    private ISelectionResponse _selectionResponse;
    private HighlightSelectionResponse highlight;
    [SerializeField] private GameObject fpscontroller;
    private Transform _selectionInteractive, _selectionUnlock;
    

    private void Awake()
    {
        _selectionResponse = GetComponent<ISelectionResponse>();
        highlight = GetComponent<HighlightSelectionResponse>();
    }

    private void Update()
    {
        if (_selectionInteractive != null)//Deseleccion
        {
            _selectionResponse.OnDeselect(_selectionInteractive);//Object in Deselection
        }
        else if (_selectionUnlock != null)
        {
            _selectionResponse.OnDeselect(_selectionUnlock);//Object in selection
        }

        _selectionInteractive = null;
        _selectionUnlock = null;

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1.5f))
        {
            var selection = hit.transform;
            highlight.defaultMaterial = selection.GetComponent<Renderer>().material;
            if (selection.CompareTag(selectableTag)) _selectionInteractive = selection;
            else if (selection.CompareTag(UnlockTag)) _selectionUnlock = selection;
        }//Raycast Region

        if (_selectionInteractive != null)//Seleccion
        {
            _selectionResponse.OnSelect(_selectionInteractive);//Object in selection
        }
        else if(_selectionUnlock != null)
        {
            _selectionResponse.Unlock(_selectionUnlock);//Object in selection
        }
    }
    public GameObject ObjetoSelecto()
    {
        try
        {
            GameObject objeto = _selectionInteractive.gameObject;
            return objeto;
        }
        catch (NullReferenceException)
        {
            return fpscontroller;
        }

    }
    public void DestruirObjeto()
    {
        Destroy(_selectionInteractive.gameObject);
    }
}
