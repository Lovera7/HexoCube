using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    float velocidad = 5f;
    float fuerzaSalto = 5F;
    int limiteSaltos = 1;
    int saltosHechos;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        saltosHechos = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (GetComponent<SpriteRenderer>().flipX == true)
            {
                GetComponent<SpriteRenderer>().flipX = false;            
            }
            transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (GetComponent<SpriteRenderer>().flipX == false)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.Translate( velocidad * -Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (saltosHechos<limiteSaltos)
            {
                rb.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
                saltosHechos++;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Suelo")
        {
            saltosHechos = 0;
        }
    }

}
