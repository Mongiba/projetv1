using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;



public class page1 : MonoBehaviour
{





    public static int d;
    protected static int f;
    protected static int ham;
    protected static int tbar;
    protected static int sobh;

    public void gomenue2()
    {
        int SelectedCharacter =
        int.Parse(EventSystem.current.currentSelectedGameObject.name);


        SceneManager.LoadScene("menue2");
        Debug.Log(SelectedCharacter);
    }
    public void gogame()
    {
        if ((d >= 0) && (d < 86400) && (f < 86400) && (f >= 0) && (tbar >= 0) && (tbar <= 10) && (ham >= 0) && (ham <= 10) && (sobh <= 10) && (sobh >= 0))
        {

            Debug.Log("true");

            SceneManager.LoadScene("game");

        }
    }


    public void Debut(string n)
    {
        d = int.Parse(n);
        Debug.Log(d);
    }

    public void Fin(string n)
    {
        f = int.Parse(n);
        Debug.Log(f);
    }
    public void Hamdoulh(string n)
    {
        ham = int.Parse(n);
        Debug.Log(ham);
    }
    public void Tbarklh(string n)
    {
        tbar = int.Parse(n);
        Debug.Log(tbar);
    }
    public void sobhanlh(string n)
    {
        sobh = int.Parse(n);
        Debug.Log(sobh);

    }
}
  