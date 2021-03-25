using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable", interactTag = "Interactive";
    private string lockerTag = "Locker";
    [SerializeField] private Color highlightedColor, defaultColor;
    [SerializeField] private Material highlightedMaterial, defaultMaterial;
    //private PickableManager pickable;
    [SerializeField] private InventoryManager bagManager;
    [SerializeField] private LockOpener unlock;
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
            if (_selection.CompareTag(interactTag))//Interactive
            {
                _selection.GetComponent<SpriteRenderer>().color = defaultColor;
               // _selection.GetComponent<FManson>().IsNotInteractive();
            }
            if (_selection.CompareTag(selectableTag))//Selectable
            {
                _selection.GetComponent<Renderer>().material = defaultMaterial;
            }
            if (_selection.CompareTag(lockerTag))//Locker
            {
                _selection.GetComponent<Renderer>().material = defaultMaterial;
            }
            _selection = null;
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 1.5f))
        {
            var selection = hit.transform;
            defaultMaterial = selection.GetComponent<Renderer>().material;
            if (selection.CompareTag(selectableTag)) //Recogible
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightedMaterial;
                    if(Input.GetButton("Fire1")) selection.GetComponent<PickableManager>().IsPickable();
                }
                _selection = selection;
            }
            if (selection.CompareTag(lockerTag)) //Locker
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightedMaterial;
                    if (Input.GetButton("Fire1"))
                    {
                        unlock.VerifyKey(selection.gameObject);
                    }
                }
                _selection = selection;
            }
            if (selection.CompareTag(interactTag)) //Interactuable
            {
                var selectionRenderer = selection.GetComponent<SpriteRenderer>();
                Debug.Log(selection.gameObject.name);
               // selection.gameObject.GetComponent<FManson>().IsInteractive(selection.gameObject.name);
                if (selectionRenderer != null)
                {
                    selectionRenderer.color = highlightedColor;
                }
                _selection = selection;
            }
        }
        if (inventory.Count != 0)
        {
            bagManager.BagUsed();
        }
        else bagManager.BagEmpty();
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
