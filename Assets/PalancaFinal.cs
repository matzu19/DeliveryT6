using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalancaFinal : MonoBehaviour
{
    [SerializeField] private GameObject PressClick, pApagar, pPrender;
    [SerializeField] private Pickable pickable;
    [SerializeField] private LoseCondition verificastate;
    private bool active;

    private void Update()
    {
        if (active)
        {
            PressClick.SetActive(true);
            if (Input.GetMouseButtonDown(0) && pickable.Agarro() == true)
            {
                pApagar.SetActive(false);
                pPrender.SetActive(true);
                PressClick.SetActive(false);
            }
            else
            {
                verificastate.perdiste();
            }
        }
        else PressClick.SetActive(false);
    }
    public bool ActivarPalancaFinal()
    {
        return active = true;
    }
    public bool DesactivarPalancaFinal()
    {
        return active = false;
    }
}
