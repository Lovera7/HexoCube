using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Para cambiar de escena necesitamos esto
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Ganaste");
        }
    }
}
