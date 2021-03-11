using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScroll : MonoBehaviour
{
    [SerializeField] private GameObject imgSelector;
    private Vector3 scale, pos;
    private int slot1 = 0, slot2 = 1, slot3 = 2;

    void Awake()
    {
        scale = new Vector3(225f, 0f, 0f);
        pos = imgSelector.transform.localPosition;
    }

    void Update()
    {

        pos -= Mathf.Clamp(Input.mouseScrollDelta.y, -1f, 1f) * scale;
        if (pos.x > 225) { pos.x = -225; }
        if (pos.x < -225) { pos.x = 225; }
        imgSelector.transform.localPosition = pos;
    }
    public int SelectorPosition()
    {
        if (pos == new Vector3(-225f, -416f, 0f))
        {
            return slot1;
        }
        else if (pos == new Vector3(0f, -416f, 0f))
        {
            return slot2;
        }
        else return slot3;
    }
}
