using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public GameObject prototipoBala;
    public GameObject personaje;
    private float ultimoDisparo;

    private void Update()
    {
        float distancia = Mathf.Abs(personaje.transform.position.x - transform.position.x);

        if (distancia < 5.0f && Time.time > ultimoDisparo * 0.25f)
        {
            Disparar();
            ultimoDisparo = Time.time;
        }
    }

    private void Disparar()
    {
        Vector3 direction;
        direction = Vector3.left;
        
        GameObject bala = Instantiate(prototipoBala, transform.position + direction * 0.5f, Quaternion.identity);
        bala.GetComponent<Bala>().SetDirection(direction);
    }
}
