using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Activacion : MonoBehaviour
{
    public GameObject desactivar;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            desactivar.SetActive(true);
            yield return new WaitForSeconds(1.8f);
            desactivar.SetActive(false);
            yield return new WaitForSeconds(3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
