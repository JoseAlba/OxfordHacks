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

	public double getCurrency(String shortcode){
		shortcode.Replace(@"[^\u0009\u000A\u000D\u0020-\u007E]", string.Empty);
		
		if(shortcode.Equals("BGN"))
			return BGN;
		if(shortcode.Equals("CAD"))
			return CAD;
		if(shortcode.Equals("BRL"))
			return BRL;
		if(shortcode.Equals("HUF"))
			return HUF;
		if(shortcode.Equals("DKK"))
			return DKK;
		if(shortcode.Equals("JPY"))
			return JPY;
		if(shortcode.Equals("ILS"))
			return ILS;
		if(shortcode.Equals("TRY"))
			return TRY;
		if(shortcode.Equals("RON"))
			return RON;
		if(shortcode.Equals("GBP"))
			return GBP;
		if(shortcode.Equals("PHP"))
			return PHP;
		if(shortcode.Equals("HRK"))
			return HRK;
		if(shortcode.Equals("NOK"))
			return NOK;
		if(shortcode.Equals("ZAR"))
			return ZAR;
		if(shortcode.Equals("MXN"))
			return MXN;
		if(shortcode.Equals("AUD"))
			return AUD;
		if(shortcode.Equals("USD"))
			return USD;
		if(shortcode.Equals("KRW"))
			return KRW;
		if(shortcode.Equals("HKD"))
			return HKD;
		if(shortcode.Equals("EUR"))
			return EUR;
		if(shortcode.Equals("ISK"))
			return ISK;
		if(shortcode.Equals("CZK"))
			return CZK;
		if(shortcode.Equals("THB"))
			return THB;
		if(shortcode.Equals("MYR"))
			return MYR;
		if(shortcode.Equals("NZD"))
			return NZD;
		if(shortcode.Equals("PLN"))
			return PLN;
		if(shortcode.Equals("CHF"))
			return CHF;
		if(shortcode.Equals("SEK"))
			return SEK;
		if(shortcode.Equals("CNY"))
			return CNY;
		if(shortcode.Equals("SGD"))
			return SGD;
		if(shortcode.Equals("INR"))
			return INR;
		if(shortcode.Equals("IDR"))
			return IDR;
		if(shortcode.Equals("RUB"))
			return RUB;
		return 0;
	}

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
