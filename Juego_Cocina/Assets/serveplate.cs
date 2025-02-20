using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class serveplate : MonoBehaviour
{
    public GameObject correcto;
    public GameObject incorrecto;
    //public TextMeshProGUI output;
    //public TMP_InputField resultado;
    public float totalCash;
    public int thisPlate;
    // Start is called before the first frame update
    void Start()
    {
        correcto.SetActive(false);
        incorrecto.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        /*public void ButtonDemo()
    {
        output.text=resultado.text;
    }*/

  private IEnumerator parar_incorrecto()
    {
        incorrecto.SetActive(true);
        yield return new WaitForSeconds(2f);
        incorrecto.SetActive(false);
    }

    private IEnumerator parar_correcto()
    {

        correcto.SetActive(true);
        yield return new WaitForSeconds(2f);
        correcto.SetActive(false);

    }

    private void OnMouseDown()
    {
        if (gameflow.orderValue[gameflow.plateNum]==gameflow.plateValue[gameflow.plateNum])
        {
            //Confirmación de que el platillo fue servido correctamente
            //output.text=resultado.text;
            
            StartCoroutine(parar_correcto());
            Debug.Log("correct"+" "+gameflow.orderTimer[gameflow.plateNum]);
        }
        else
        {
            StartCoroutine(parar_incorrecto());
            Debug.Log("incorrect");
        }


        gameflow.emptyPlateNow=transform.position.x;
        StartCoroutine(platereset());

    }

    IEnumerator platereset()
    {
        yield return new WaitForSeconds(.3f);
        gameflow.emptyPlateNow=-1;
        //gameflow.totalCash+=gameflow.orderTimer[thisPlate]*.10f;
        //Debug.Log(gameflow.totalCash);
    }
}
