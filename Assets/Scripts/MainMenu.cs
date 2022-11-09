using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("juego");
    }

    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene("nombreNivel");
    }

    public void PasarNivel(string nombreNivel)
    {
        SceneManager.LoadScene("nivel2");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
