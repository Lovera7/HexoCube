using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar_Jugador : MonoBehaviour
{
    public Transform spawn; //lugar de origen del  jugador
    public GameObject Jugador; //Asset Jugador

    //Cuando choquen colliders y se calide de que sea el jugador se eliminara y se instanciara uno nuevo
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log(other.tag);
            Destroy(other.gameObject);
            Instantiate(Jugador, spawn.position, spawn.rotation);
        }
    }
}
