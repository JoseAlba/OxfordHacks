using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Rates {
	public double BGN;
	public double CAD;
	public double BRL;
	public double HUF;
	public double DKK;
	public double JPY;
	public double ILS;
	public double TRY;
	public double RON;
	public double GBP;
	public double PHP;
	public double HRK;
	public double NOK;
	public double ZAR;
	public double MXN;
	public double AUD;
	public double USD;
	public double KRW;
	public double HKD;
	public double EUR;
	public double ISK;
	public double CZK;
	public double THB;
	public double MYR;
	public double NZD;
	public double PLN;
	public double CHF;
	public double SEK;
	public double CNY;
	public double SGD;
	public double INR;
	public double IDR;
	public double RUB;

	public override string ToString(){
		return "BGN: " + this.BGN +
			"\nCAD: " + this.CAD +
			"\nBRL: " + this.BRL +
			"\nHUF: " + this.HUF +
			"\nDKK: " + this.DKK +
			"\nJPY: " + this.JPY +
			"\nILS: " + this.ILS +
			"\nTRY: " + this.TRY +
			"\nRON: " + this.RON +
			"\nGBP: " + this.GBP +
			"\nPHP: " + this.PHP +
			"\nHRK: " + this.HRK +
			"\nNOK: " + this.NOK +
			"\nZAR: " + this.ZAR +
			"\nMXN: " + this.MXN +
			"\nAUD: " + this.AUD +
			"\nUSD: " + this.USD +
			"\nKRW: " + this.KRW +
			"\nHKD: " + this.HKD +
			"\nEUR: " + this.EUR +
			"\nISK: " + this.ISK +
			"\nCZK: " + this.CZK +
			"\nTHB: " + this.THB +
			"\nMYR: " + this.MYR +
			"\nNZD: " + this.NZD +
			"\nPLN: " + this.PLN +
			"\nCHF: " + this.CHF +
			"\nSEK: " + this.SEK +
			"\nCNY: " + this.CNY +
			"\nSGD: " + this.SGD +
			"\nINR: " + this.INR +
			"\nIDR: " + this.IDR +
			"\nRUB: " + this.RUB;
	} 
}
