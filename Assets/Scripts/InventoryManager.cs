using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    private GameObject[] bag;
    [SerializeField] private SelectManager selector;
    [SerializeField] private Image[] image;
    [SerializeField] private Sprite[] resources;
    private bool bagInUse;

    private void Update()
    {
        if (bagInUse)
        {
            bag = selector.TemporaryInventory();
            for(int i = 0; i < bag.Length; i++)
            {
                if(bag[i].name == "Cube")
                {
                    image[i].sprite = resources[1]; 
                }
                else if (bag[i].name == "Sphere")
                {
                    image[i].sprite = resources[2];
                }
                else if (bag[i].name == "Triangle")
                {
                    image[i].sprite = resources[3];
                }
                else if (bag[i].name == "box")
                {
                    image[i].sprite = resources[4];
                }
            }
        }
        if (Input.GetKey(KeyCode.G)) //Borrar cuando ya este todo implementado. esto es solo de verificacion
        {
            for (int i = 0; i <3; i++)
            {
                Debug.Log(bag[i].name);
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

}
