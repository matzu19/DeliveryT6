using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private string[] bag;
    [SerializeField] private Pickable arreglo;
    [SerializeField] private Image[] image;
    [SerializeField] private Sprite[] resources;
    private bool bagInUse;

    private void Update()
    {
        if (bagInUse)
        {
            bag = arreglo.TemporaryInventory();
            for (int i = 0; i < bag.Length; i++)
            {
                if(bag[i] == "Screw")
                {
                    image[i].sprite = resources[1];
                    image[i].color = new Color(1f, 1f, 1f, 1f); 
                }
                else if (bag[i] == "Gloves")
                {
                    image[i].sprite = resources[2];
                    image[i].color = new Color(1f, 1f, 1f, 1f);
                }
                else if (bag[i] == "Lever")
                {
                    image[i].sprite = resources[3];
                    image[i].color = new Color(1f, 1f, 1f, 1f);
                }
            }
        }
        if (Input.GetKey(KeyCode.G)) //Borrar cuando ya este todo implementado. esto es solo de verificacion
        {
            for (int i = 0; i <3; i++)
            {
                Debug.Log(bag[i]);
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
        return bag[x];
    }
}
