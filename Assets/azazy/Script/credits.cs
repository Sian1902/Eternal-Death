using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    [SerializeField] GameObject mainmenu, creditsmenu;
    public void credit()
    {
        creditsmenu.SetActive(true);
        mainmenu.SetActive(false);
    }
    public void retur()
    {
        creditsmenu.SetActive(false);   
        mainmenu.SetActive(true);
    }
}
