using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;

    void Update()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Rigidbody2D.velocity = Direction * velocidad;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }

    public void DestruirBala()
    {
        Destroy(gameObject);
    }
}
