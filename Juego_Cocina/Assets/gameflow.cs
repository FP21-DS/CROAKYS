//Creación de Variables
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow:MonoBehaviour
{
	public static int []orderValue={10020, 10003, 03100};
	public static int []plateValue={0,0,0};
	public static float []orderTimer= {60,60,60};

	public static int plateNum=0;
	public static float plateXpos=-3;

	public Transform plateSelector;

	public MeshRenderer []currentPic;

	public Texture []orderPics;

	public static float emptyPlateNow=-1;
	
	public static float totalCash=0;

	public static float [] orderCost={1,2.5f,3.5f};

	public static int createdMenuItem;
	//Intento Lista
	public int []orders;

	public static int [] FullMenu={0,0,0,0,0,0,0,0,0};

	
	void Start()
	{
		/*orderValue[0]=FullMenu[0];
		orderValue[1]=FullMenu[0];
		orderValue[2]=FullMenu[0];*/
	
		for (int rep=0; rep<3; rep+=1)
		{
			for (int indice=0; indice<orders.Length; indice++)
			{
				if (orderValue[rep]==orders[indice])
					currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture=orderPics[indice];
			}
			
		
		}
	}

	void Update()
	{
		// Si el valor de imagen es equivalente al valor del índice (valor del plato) entonces proyectalo en el plano
		if (Input.GetKeyDown("tab"))
		{
			plateNum+=1;
			plateXpos+=4;

			if (plateNum>2)
			{
				plateNum=0;
				plateXpos=-3;
			}
		}

		orderTimer[0]-=Time.deltaTime;
		orderTimer[1]-=Time.deltaTime;
		orderTimer[2]-=Time.deltaTime;

		plateSelector.transform.position=new Vector3(plateXpos, 4.6f, -10);
	}
}