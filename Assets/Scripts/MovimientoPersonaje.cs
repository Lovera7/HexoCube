using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    float velocidad = 5f;
    public float fuerzaSalto = 5F;
    int limiteSaltos = 1;
    int saltosHechos;
    public GameObject sonidoSalto;
    public GameObject balaPrototipo;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        saltosHechos = 0;
    }

    void Update()
    {
        //mover a la derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Este if sirve para que el personaje gire a la derecha o izquierda
            if (GetComponent<SpriteRenderer>().flipX == true)
            {
                GetComponent<SpriteRenderer>().flipX = false;            
            }
            transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        //mover a la izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Este if sirve para que el personaje gire a la derecha o izquierda
            if (GetComponent<SpriteRenderer>().flipX == false)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.Translate( velocidad * -Time.deltaTime, 0, 0);
        }

        //para realizar saltos
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (saltosHechos<limiteSaltos)
            {
                rb.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
                saltosHechos++;
                Instantiate(sonidoSalto);
            }
        }

        // presionar boton de disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    // Funcion para disparar
    private void Shoot()
    {
        Vector3 direction;

        if (GetComponent<SpriteRenderer>().flipX == false) direction = Vector2.right;
        else direction = Vector2.left;

        GameObject bala = Instantiate(balaPrototipo, transform.position + direction * 0.1f, Quaternion.identity);
        bala.GetComponent<Bala>().SetDirection(direction);
    }

    //para reserear la cantidad de saltos que se puedan realizar
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Suelo")
        {
            saltosHechos = 0;
        }
    }

}
