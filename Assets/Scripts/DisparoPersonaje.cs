using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPersonaje : MonoBehaviour
{
    public GameObject balaPrototipo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Vector3 direction;

        if (transform.localScale.x == 1.0f) direction = Vector2.right;
        else direction = Vector2.left;
 
        GameObject bala = Instantiate(balaPrototipo, transform.position + direction * 0.1f, Quaternion.identity);
        bala.GetComponent<Bala>().SetDirection(direction);
    }
}
