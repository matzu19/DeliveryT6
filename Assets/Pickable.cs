using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickable : MonoBehaviour
{
    private List<string> inventory;
    [SerializeField] private GameObject pickableObject;
    [SerializeField] private InventoryManager bagManager;
    [SerializeField] private SelectionManager objetoSelecto;

    [SerializeField] private Screw tornillo;
    [SerializeField] private Gloves guantes;
    [SerializeField] private Lever palanca;

    private void Awake()
    {
        inventory = new List<string>();
    }
    private void FixedUpdate()
    {
        pickableObject = objetoSelecto.ObjetoSelecto();
        if(pickableObject.name != null)
        {
            tornillo = pickableObject.GetComponent<Screw>();
            guantes = pickableObject.GetComponent<Gloves>();
            palanca = pickableObject.GetComponent<Lever>();
            switch (pickableObject.name)
            {
                case "Screw":
                    if (Input.GetMouseButtonDown(0))
                    {
                        tornillo.RecogerObjeto();
                        objetoSelecto.DestruirObjeto();
                    }
                    break;
                case "Gloves":
                    if (Input.GetMouseButtonDown(0))
                    {
                        guantes.RecogerObjeto();
                    }
                    break;
                case "Lever":
                    if (Input.GetMouseButtonDown(0))
                    {
                        palanca.RecogerObjeto();
                    }
                    break;
                case null:
                    break;
            }
        }
        
        if (inventory.Count != 0)
        {
            bagManager.BagUsed();
        }
        else bagManager.BagEmpty();
    }
    public void AddObject(string gObject)
    {
        inventory.Add(gObject);
    }
    public string[] TemporaryInventory()
    {
        string[] tempInventory = inventory.ToArray();
        return tempInventory;
    }
}
