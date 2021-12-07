using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTorreta : MonoBehaviour
{
    public GameObject laser; //Asset de laser
    public float tiempoDesactivado; //tiempo desactivacion laser

    IEnumerator Start()
    {
        while (true)
        {
            laser.SetActive(true); //Desactivamos el laser
            yield return new WaitForSeconds(2f);
            laser.SetActive(false); //Activamos el laser
            yield return new WaitForSeconds(tiempoDesactivado);
        }
    }
}
