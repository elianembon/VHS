using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hud : MonoBehaviour
{
    public GameObject[] Hearts;

    public void DesactiveLife(int indice)
    {
        Hearts[indice - 1].SetActive(false);
    }

    public void ActiveLife(int i)
    {
        Hearts[i].SetActive(true);
    }
}

