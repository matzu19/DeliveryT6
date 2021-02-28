using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    //private PickableManager pickable;
    [SerializeField] private InventoryManager bagManager;
    private List<GameObject> inventory;


    private Transform _selection;
    private void Awake()
    {
        inventory = new List<GameObject>();
    }
    void Update()
    {
        if(_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 1.5f))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                    if(Input.GetButton("Fire1")) selection.GetComponent<PickableManager>().IsPickable();
                }
                _selection = selection;
            }
        }
        if (inventory.Count != 0)
        {
            bagManager.BagUsed();
        }
        else bagManager.BagEmpty();
        if (Input.GetKeyDown(KeyCode.H)) Debug.Log(inventory.Count);  //Borrar cuando ya este todo implementado. esto es solo de verificacion
    }

    public void AddObject(GameObject gObject)
    {
        if(inventory.Count <3) inventory.Add(gObject);
    }
    public GameObject[] TemporaryInventory()
    {
        GameObject[] tempInventory = inventory.ToArray();
        return tempInventory;
    }
}
