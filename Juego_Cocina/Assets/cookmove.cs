//Alimento va a plato
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookmove : MonoBehaviour
{
    private int foodValue=0;
    //Cambiar de color mientras se cocina
    private MeshRenderer meatMat;
    private MeshRenderer serpentMat;
    //private MeshRenderer thirdMat;
    //Controlador, en caso de no quitarse el platillo a tiempo, el platillo no cambia de color
    private string stillcooking="y";

    // Start is called before the first frame update
    void Start()
    {
        //variable asignada a objeto que cambiará de color
        meatMat= GetComponent<MeshRenderer>();
        serpentMat= GetComponent<MeshRenderer>();
        //thirdMat= GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Transform>().position= new Vector3(gameflow.plateXpos, 8, -10.5f);
        gameflow.plateValue[gameflow.plateNum] += foodValue;
        stillcooking="n";
        //GetComponent<Collider>().enabled = false;
        //GetComponent<Rigidbody>().isKinematic = true;
        
    }

    IEnumerator cookTimer()
    {
        if (gameObject.tag=="serpiente_instancia")
        {
           yield return new WaitForSeconds(5);
        //este objeto no obtiene el valor necesario para pasar al plato hasta que se cocine
        foodValue=10;
        //Si seleccionas el alimento antes de que se cocine, saldrá crudo
        if (stillcooking=="y")
        meatMat.material.color=new Color(.3f, .3f, .3f);
        serpentMat.material.color=new Color(.3f, .3f, .3f);
        //thirdMat.material.color=new Color(.3f, .3f, .3f);
        }

        if (gameObject.tag=="percebe_instancia")
        {
            yield return new WaitForSeconds(5);
        //este objeto no obtiene el valor necesario para pasar al plato hasta que se cocine
        foodValue=1000;
        //Si seleccionas el alimento antes de que se cocine, saldrá crudo
        if (stillcooking=="y")
        meatMat.material.color=new Color(.3f, .3f, .3f);
        serpentMat.material.color=new Color(.3f, .3f, .3f);
        //thirdMat.material.color=new Color(.3f, .3f, .3f);
        }


        if (gameObject.tag=="sardina_instancia")
        {
            yield return new WaitForSeconds(5);
        //este objeto no obtiene el valor necesario para pasar al plato hasta que se cocine
        foodValue=100;
        //Si seleccionas el alimento antes de que se cocine, saldrá crudo
        if (stillcooking=="y")
        meatMat.material.color=new Color(.3f, .3f, .3f);
        serpentMat.material.color=new Color(.3f, .3f, .3f);
        //thirdMat.material.color=new Color(.3f, .3f, .3f);
        }

        if (gameObject.tag=="Babosa_instancia")
        {
            yield return new WaitForSeconds(5);
        //este objeto no obtiene el valor necesario para pasar al plato hasta que se cocine
        foodValue=1;
        //Si seleccionas el alimento antes de que se cocine, saldrá crudo
        if (stillcooking=="y")
        meatMat.material.color=new Color(.3f, .3f, .3f);
        serpentMat.material.color=new Color(.3f, .3f, .3f);
        //thirdMat.material.color=new Color(.3f, .3f, .3f);
        }

        /*yield return new WaitForSeconds(5);
        //este objeto no obtiene el valor necesario para pasar al plato hasta que se cocine
        foodValue=10;
        //Si seleccionas el alimento antes de que se cocine, saldrá crudo
        if (stillcooking=="y")
        meatMat.material.color=new Color(.3f, .3f, .3f);
        serpentMat.material.color=new Color(.3f, .3f, .3f);
        //thirdMat.material.color=new Color(.3f, .3f, .3f);
        */

    }
}
