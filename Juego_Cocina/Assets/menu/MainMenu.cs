using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("MainStory"); //cambiar el nombre de game por el nombre de la escena del juego y luego referenciarla desde el scene manager de Unity
        
    }

    public void Quit()
    {
        Application.Quit();
    }


}
