using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private bool pressed = false;
    public GameObject Gate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" & !pressed)
        {
            Debug.Log("Button is pressed");
            pressed = true;
            Gate.SetActive(true);
        }
    }
}
