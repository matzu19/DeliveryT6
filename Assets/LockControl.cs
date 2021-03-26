using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LockControl :  MonoBehaviour
{
    [SerializeField] private Unlock puzzleDone;
    [SerializeField] private string code;
    [SerializeField] private TMP_Text codeScreen;
    private Playsound click;
    private bool code4less;

    private void Awake()
    {
        click = GetComponent<Playsound>();
        code4less = true;
    }
    private void Update()
    {
        if (code.Length < 4)
        {
            code4less = true;
            codeScreen.text = code;
        }
        else if(code.Length == 4)
        {
            code4less = false;
            codeScreen.text = code;
        }
        else code4less = false;
    }
    public void Press1()
    {
        if (code4less)
        {
            click.Clicky();
            code += "1";
        }
    }
    public void Press2()
    {
        if (code4less)
        {
            click.Clicky();
            code += "2";
        }
    }
    public void Press3()
    {
        if (code4less)
        {
            click.Clicky();
            code += "3";
        }
    }
    public void Press4()
    {
        if (code4less)
        {
            click.Clicky();
            code += "4";
        }
    }
    public void Press5()
    {
        if (code4less)
        {
            click.Clicky();
            code += "5";
        }
    }
    public void Press6()
    {
        if (code4less)
        {
            click.Clicky();
            code += "6";
        }
    }
    public void Press7()
    {
        if (code4less)
        {
            click.Clicky();
            code += "7";
        }
    }
    public void Press8()
    {
        if (code4less)
        {
            click.Clicky();
            code += "8";
        }
    }
    public void Press9()
    {
        if (code4less)
        {
            click.Clicky();
            code += "9";
        }
    }
    public void Press0()
    {
        if (code4less)
        {
            click.Clicky();
            code += "0";
        }
    }
    public void PressCheck()
    {
        if (codeScreen.text.Length == 4 && codeScreen.text == "1934" && codeScreen.color != Color.green)
        {
            click.ClickyDone();
            codeScreen.color = Color.green;
            StartCoroutine(CodigoCorrecto());
        }
        else StartCoroutine(ErrorDeCodigo());
    }
    public void PressCorrect()
    {
        if (codeScreen.text.Length > 0 && codeScreen.color != Color.green)
        {
            click.Clicky();
            code = codeScreen.text.Substring(0, code.Length - 1);
        }
        else code = null;
    }

    IEnumerator CodigoCorrecto()
    {
        yield return new WaitForSeconds(1f);
        puzzleDone.UnlockedPuzzle();

    }
    IEnumerator ErrorDeCodigo()
    {
        click.ClickyFix();
        code4less = false;
        codeScreen.color = Color.red;
        yield return new WaitForSeconds(1f);
        code = code.Remove(0);
        codeScreen.color = Color.white;
        code4less = true;

    }
}
