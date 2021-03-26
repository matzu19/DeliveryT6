using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickable : MonoBehaviour
{
    private List<string> inventory;
    [SerializeField] private GameObject pickableObject, PressClick, pApagar, pPrender;
    [SerializeField] private InventoryManager bagManager;
    [SerializeField] private SelectionManager objetoSelecto;

    private Screw tornillo;
    private Gloves guantes;
    private Lever palanca;

    private void Awake()
    {
        inventory = new List<string>();
    }
    private void FixedUpdate()
    {
        //Debug.Log(inventory.Count);
        pickableObject = objetoSelecto.ObjetoSelecto();
        if(pickableObject.name != null)
        {
            tornillo = pickableObject.GetComponent<Screw>();
            guantes = pickableObject.GetComponent<Gloves>();
            palanca = pickableObject.GetComponent<Lever>();
            switch (pickableObject.name)
            {
                case "Screw":
                    PressClick.SetActive(true);
                    if (Input.GetMouseButtonDown(0))
                    {
                        tornillo.RecogerObjeto();
                        objetoSelecto.DestruirObjeto();
                        PressClick.SetActive(false);
                    }
                    break;
                case "Gloves":
                    PressClick.SetActive(true);
                    if (Input.GetMouseButtonDown(0))
                    {
                        guantes.RecogerObjeto();
                        objetoSelecto.DestruirObjeto();
                        PressClick.SetActive(false);
                    }
                    break;
                case "Lever":
                    PressClick.SetActive(true);
                    if (Input.GetMouseButtonDown(0))
                    {
                        palanca.RecogerObjeto();
                        objetoSelecto.DestruirObjeto();
                        PressClick.SetActive(false);
                    }
                    break;

                case null:
                    PressClick.SetActive(false);
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
    public void RemovePalanca(string gObject)
    {
        inventory.Remove(gObject);
        bagManager.BorrarPalanca();
    }
    public void RemoveTornillo(string gObject)
    {
        inventory.Remove(gObject);
        bagManager.BorrarTornillo();
    }
    public string[] TemporaryInventory()
    {
        string[] tempInventory = inventory.ToArray();
        return tempInventory;
    }
}
