using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickableManager : MonoBehaviour
{
    [SerializeField] private bool pickable;
    [SerializeField] private SelectManager selector;
    [SerializeField] private Sprite sprite;

    public void IsPickable()
    {
        if (pickable == true && InventorySize() < 3)
        {
            gameObject.SetActive(false);
            selector.AddObject(this.gameObject);
        }
    }

    private int InventorySize()
    {
        GameObject[] temp = selector.TemporaryInventory();
        return temp.Length;
    }
}
