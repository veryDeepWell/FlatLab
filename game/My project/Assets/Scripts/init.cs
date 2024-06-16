using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    public GameObject[] toDeactivate;

    void Start()
    {
        foreach (var item in toDeactivate)
        {
            item.gameObject.SetActive(false);
        }
    }
}
