using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    public GameObject sonidoExoplosion;

    void Update()
    {
        // Definir la velocidad de nuestra bala
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Rigidbody2D.velocity = Direction * velocidad;
    }

    // Definir direccion de la bala
    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }

    // Destruir bala
    public void DestruirBala()
    {
        Destroy(gameObject);
    }

    // Colisiones para eliminar bala y torreta
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pared" || other.tag == "Suelo")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Torreta")
        {
            Destroy(other.gameObject);
            Instantiate(sonidoExoplosion);
            Destroy(gameObject);
        }
    }
}
