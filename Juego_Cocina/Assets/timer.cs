using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject tiempo;
    // Start is called before the first frame update
    void Start()
    {
         tiempo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //StartCoroutine(parar_correcto());
}
