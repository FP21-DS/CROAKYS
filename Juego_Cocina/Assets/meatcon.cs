//Alimento va a sartén
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatcon:MonoBehaviour
{
	public Transform cloneObj;
	//public int foodValue;
	void Start()
	{

	}

	void Update()
	{
		
	}

	private void OnMouseDown()
	{
		if (gameObject.name=="sardina")
			Instantiate(cloneObj, new Vector3(0, 5, -16.6f), cloneObj.rotation);

		if (gameObject.name=="serpiente")
			Instantiate(cloneObj, new Vector3(0, 5, -16.6f), cloneObj.rotation);

		if (gameObject.name=="percebe")
			Instantiate(cloneObj, new Vector3(0, 5, -16.6f), cloneObj.rotation);

		if (gameObject.name=="Babosa")
			Instantiate(cloneObj, new Vector3(0, 5, -16.6f), cloneObj.rotation);
	}
}