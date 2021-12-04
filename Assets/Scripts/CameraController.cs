using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position - player.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + posicion;
    }
}