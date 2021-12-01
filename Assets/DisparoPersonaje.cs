using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPersonaje : MonoBehaviour
{
    public GameObject balaPrototipo;
    public Transform spawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(balaPrototipo, spawn);
        }
    }
}
