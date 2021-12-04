using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Activacion : MonoBehaviour
{
    public GameObject laser; //Asset de laser
    public float tiempoDesactivado; //tiempo desactivacion laser

    // Creamos un IEnumerator para que se repita en bucle la animacion
    IEnumerator Start()
    {
        while (true)
        {
            laser.SetActive(true); //Desactivamos el laser
            yield return new WaitForSeconds(1.8f);
            laser.SetActive(false); //Activamos el laser
            yield return new WaitForSeconds(tiempoDesactivado);
        }
    }
}
