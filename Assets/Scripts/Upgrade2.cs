﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Upgrade2 : MonoBehaviour {

	public Clic2 click;
	public UnityEngine.UI.Text itemNameInfo;
	public UnityEngine.UI.Text itemDPSInfo;
	public UnityEngine.UI.Text itemCountInfo;
	public UnityEngine.UI.Text itemCoutInfo;
	public float cost;
	public float count = 0;
	public float clickPower;
	public float baseClickPower;
	public string itemName;
	public Color standart;
	public Color affordable;
	public Image button;
	//public GameObject unlockNext;

	public int Up = 0;
	public float Power = 1.09f;

	private int i;
	private float MultipleCost10X;
	private int Flag10X = 0;
	private float MultipleCost25X;
	private int Flag25X = 0;
	private float MultipleCost100X;
	private int Flag100X = 0;


	public int Flag = 0;

	private float baseCost;

	// Use this for initialization
	void Start () {
		baseCost = cost;
		baseClickPower = clickPower;
		//unlockNext.SetActive(false);

		itemNameInfo.text = itemName;
		itemDPSInfo.text = "Puissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(clickPower, false, false, false) + " C/c";
		itemCoutInfo.text = "Cout : " + CurrencyConverter.Instance.GetCurrencyIntoString (cost, false, false, false);
		itemCountInfo.text = count.ToString ("F0");
	}
	
	// Update is called once per frame
	void Update () {
		if(click.gold >= cost ){
			GetComponent<Image>().color = affordable;
		//	unlockNext.SetActive(true);

		}else{
			GetComponent<Image>().color = standart;
		}

		if (count <= 0) {
			button.color = standart;
		} else {
			button.color = affordable;
		}

		PowerUp ();

	}

	public void PurchasedUpgrade(){


			click.gold -= MultipleCost10X;
			count += 10;
		click.goldPerClick += ((clickPower*10) + ((clickPower/100)));
			cost = baseCost * Mathf.Pow (1.09f, count);
		
	}


	public void PowerUp(){ // Permets de doubler la puissance des degats des armes par tranche de niveau :) 
		if (count >= 10 && Up == 0) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (10*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 50 && Up == 1) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (50*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 100 && Up == 2) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (100*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 200 && Up == 3) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (200*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 300 && Up == 4) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (300*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 400 && Up == 5) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (400*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 500 && Up == 6) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (500*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
	}

}
