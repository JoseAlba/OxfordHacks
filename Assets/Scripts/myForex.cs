using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class myForex {
	public string date;
	public Rates rates;
	
	// [JsonProperty("base")]
 	public string @base;

	public string getDate(){
		return this.date;
	}

	public Rates getRates(){
		return this.rates;
	}
	public string getBase(){
		return this.@base;
	}

	public override string ToString(){
		return "date: " + this.date + "\nrates: {" + this.rates.ToString() + "\n},\nbase: " + this.@base;
	}

}
