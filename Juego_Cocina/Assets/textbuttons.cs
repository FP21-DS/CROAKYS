using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*public void settext(string text)
    {
        Text txt=trasnform.Find("Text").
        GetComponent<Text>();

    } */

    public void EscenaGame()
    {
        SceneManager.LoadScene("game");
    }  
    private void OnMouseDown()
    {
        if (gameObject.name=="Reset")
        gameflow.emptyPlateNow=0;

        if (gameObject.name=="Agregar a menu")
        {
            gameflow.FullMenu[0]=gameflow.createdMenuItem;
            gameflow.emptyPlateNow=0;
            Debug.Log(gameflow.createdMenuItem);
        }

        if (gameObject.name=="Iniciar")
        {
            SceneManager.LoadScene("game");
        }
    }
}
