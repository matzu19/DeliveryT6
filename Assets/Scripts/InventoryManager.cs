using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private string[] bag;
    [SerializeField] private Pickable arreglo;
    [SerializeField] private Image[] image;
    [SerializeField] private Sprite[] resources;
    private bool bagInUse;

    private void Update()
    {
        //Debug.Log(bagInUse);
        if (bagInUse)
        {
            bag = arreglo.TemporaryInventory();
            for (int i = 0; i < bag.Length; i++)
            {
                if (bag[i] == null)
                {
                    image[i].sprite = null;
                    image[i].color = new Color(1f, 1f, 1f, 0f);
                }
                else  if (bag[i] == "Screw")
                {
                    image[i].sprite = resources[0];
                    image[i].color = new Color(1f, 1f, 1f, 1f); 
                }
                else if (bag[i] == "Gloves")
                {
                    image[i].sprite = resources[1];
                    image[i].color = new Color(1f, 1f, 1f, 1f);
                }
                else if (bag[i] == "Lever")
                {
                    image[i].sprite = resources[2];
                    image[i].color = new Color(1f, 1f, 1f, 1f);
                }
            }
        }
        else
        {
            for (int i = 0; i < bag.Length; i++)
            {
                if (bag[i] == null)
                {
                    image[i].sprite = null;
                    image[i].color = new Color(1f, 1f, 1f, 0f);
                }
            }
        }
    }
    public void BagUsed()
    {
        bagInUse = true;
    }
    public void BagEmpty()
    {
        bagInUse = false;
    }
    public string Item(int x)
    {
        try { return bag[x]; }
        catch (IndexOutOfRangeException)
        {
            return null;
        }
    }
    public void BorrarPalanca()
    {
        for (int i = 0; i < bag.Length; i++)
        {
            if (bag[i] == "Lever")
            {
                image[i].sprite = null;
                image[i].color = new Color(1f, 1f, 1f, 0f);
            }  
        }
    }
    public void BorrarTornillo()
    {
        for (int i = 0; i < bag.Length; i++)
        {
            if (bag[i] == "Screw")
            {
                image[i].sprite = null;
                image[i].color = new Color(1f, 1f, 1f, 0f);
            }
        }
    }
}
