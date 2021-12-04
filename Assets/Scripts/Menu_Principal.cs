using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Para cambiar de escena necesitamos esto
using UnityEngine.SceneManagement;

public class Menu_Principal : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void EscenaControles()
    {
        SceneManager.LoadScene("Controles");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu_Principal");
    }
}
