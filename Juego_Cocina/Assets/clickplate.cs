using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickplace:MonoBehaviour
{
	public Transform cloneObj;
	public int foodValue;
	
	void Start()
	{

	}	

	void Update()
	{

	}

	private void OnMouseDown()
	{
		//Escrobir nombre del objeto/ingrediente seleccionable
		if (gameObject.name=="alga")
		{
			Instantiate(cloneObj, new Vector3(gameflow.plateXpos -.3f, 6, -10.66f), cloneObj.rotation);
			Instantiate(cloneObj, new Vector3(gameflow.plateXpos +.3f, 6, -10.67f), cloneObj.rotation);
			Instantiate(cloneObj, new Vector3(gameflow.plateXpos +.6f, 6, -10.68f), cloneObj.rotation);
			Instantiate(cloneObj, new Vector3(gameflow.plateXpos -.6f, 6, -10.69f), cloneObj.rotation);
		}

		/*if (gameObject.name=="alga")
		Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 6, -10.68f), cloneObj.rotation);

		if (gameObject.name=="sardina")
		Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 6, -10.66f), cloneObj.rotation= Quaternion.Euler(0, 0, -180));

		if (gameObject.name=="serpiente")
		Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 6, -10.66f), cloneObj.rotation= Quaternion.Euler(0, 0, -180));

		if (gameObject.name=="percebe")
		Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 6, -10.66f), cloneObj.rotation= Quaternion.Euler(0, 0, -180));





		/*if (gameObject.name=="Cheese")
		Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 5.5f, 0), cloneObj.rotation);

		if (gameObject.name=="Bacon")
		{
			Instantiate(cloneObj, new Vector3(gameflow.plateXpos -.3f, 5.2f, 0), cloneObj.rotation);
			Instantiate(cloneObj, new Vector3(gameflow.plateXpos +.3f, 5.2f, 0), cloneObj.rotation);
		}*/

		gameflow.plateValue[gameflow.plateNum] +=foodValue;
		Debug.Log(gameflow.plateValue[gameflow.plateNum]+" "+gameflow.orderValue[gameflow.plateNum]);

	}
}