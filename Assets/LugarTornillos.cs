using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LugarTornillos : MonoBehaviour
{
    [SerializeField] private SelectionManager selected;
    [SerializeField] private PuzzleManager item;
    [SerializeField] private Pickable lista;
    [SerializeField] private GameObject PressClick, tornillo;
    [SerializeField] private Collider holder;

    [SerializeField] private Image pickImg;
    private float timeHeld;

    private bool EsElLugar;

    private void Update()
    {

        if (EsElLugar)
        {
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
                holder.enabled = !holder.enabled;
                StartCoroutine(ColocarTornillo());
                Debug.Log("puesto en el lugar");

            }
        }
        else
        {
            this.timeHeld = 0;
            pickImg.color = new Color(0f, this.timeHeld, 0f, 0f);
        }
    }
    public bool EsElLugarCorrecto()
    {
        return EsElLugar = true;
    }
    public bool NoEsElLugarCorrecto()
    {
        PressClick.SetActive(false);
        return EsElLugar = false; ;
    }
    IEnumerator ColocarTornillo()
    {
        PressClick.SetActive(false);
        tornillo.SetActive(true);
        lista.RemoveTornillo(item.SelectedItem());
        yield return null;
    }
}