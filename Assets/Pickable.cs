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
    [SerializeField] private Image pickImg;
    [SerializeField] private bool agarro;

    private Screw tornillo;
    private Gloves guantes;
    private Lever palanca;
    [SerializeField] private float timeHeld;

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
                    if (Input.GetMouseButton(0))
                    {
                        this.timeHeld += Time.deltaTime;
                        pickImg.color = new Color(0f, this.timeHeld, 0f, 1f);
                    }
                    else if (Input.GetMouseButtonUp(0))
                    {
                        this.timeHeld = 0;
                        pickImg.color = new Color(0f, this.timeHeld, 0f, 0f);
                    }

                    if (this.timeHeld > 1f)
                    {
                        tornillo.RecogerObjeto();
                        objetoSelecto.DestruirObjeto();
                        PressClick.SetActive(false);
                        reseteo();
                    }
                    break;
                case "Gloves":
                    PressClick.SetActive(true);
                    if (Input.GetMouseButton(0))
                    {
                        this.timeHeld += Time.deltaTime;
                        pickImg.color = new Color(0f, this.timeHeld, 0f, 1f);
                    }
                    else if (Input.GetMouseButtonUp(0))
                    {
                        this.timeHeld = 0;
                        pickImg.color = new Color(0f, this.timeHeld, 0f, 0f);
                    }

                    if (this.timeHeld > 1f)
                    {
                        guantes.RecogerObjeto();
                        objetoSelecto.DestruirObjeto();
                        PressClick.SetActive(false);
                        agarro = true;
                        reseteo();
                    }
                    break;
                case "Lever":
                    PressClick.SetActive(true);
                    if (Input.GetMouseButton(0))
                    {
                        this.timeHeld += Time.deltaTime;
                        pickImg.color = new Color(0f, this.timeHeld, 0f, 1f);
                    }
                    else if (Input.GetMouseButtonUp(0))
                    {
                        this.timeHeld = 0;
                        pickImg.color = new Color(0f, this.timeHeld, 0f, 0f);
                    }

                    if (this.timeHeld > 1f)
                    {
                        palanca.RecogerObjeto();
                        objetoSelecto.DestruirObjeto();
                        PressClick.SetActive(false);
                        reseteo();
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
    public bool Agarro()
    {
        return agarro;
    }
    public void reseteo()
    {
        this.timeHeld = 0;
        pickImg.color = new Color(0f, this.timeHeld, 0f, 0f);
    }
}
