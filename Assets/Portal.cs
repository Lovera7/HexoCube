using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Para cambiar de escena necesitamos esto
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log(other.tag);
            //Destroy(other.gameObject);
            //Instantiate(Jugador, spawn.position, spawn.rotation);
            SceneManager.LoadScene("Ganaste");
        }
    }
}
