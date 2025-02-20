using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucreate : MonoBehaviour
{
    public GameObject cloneObj;
    public int foodValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameflow.createdMenuItem+=foodValue;

        if (gameObject.name!="1000")
        Instantiate(cloneObj, new Vector3(-.5f,.5f,-3), cloneObj.transform.rotation);
        else
        Instantiate(cloneObj, new Vector3(-.5f,-.15f,-3), cloneObj.transform.rotation);

    }
}
