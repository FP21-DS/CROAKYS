using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SKIP : MonoBehaviour
{
  public void Skipp()
    {
        SceneManager.LoadScene("game"); //cambiar el nombre de game por el nombre de la escena del juego y luego referenciarla desde el scene manager de Unity
        
    }
}
