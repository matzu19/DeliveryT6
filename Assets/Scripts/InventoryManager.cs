using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private GameObject[] bag;
    [SerializeField] private SelectManager selector;
    private bool bagInUse;

    private void Update()
    {
        if (bagInUse)
        {
            bag = selector.TemporaryInventory();
            for(int i = 0; i < bag.Length; i++)
            {if(bag[i].name == "Cubo")
                {

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
