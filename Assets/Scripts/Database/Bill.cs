using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// namespace Database{
[Serializable]
	public class Bill{

		public string key;
		public string photo;
		public int worth;
		public string code;
		public string history;

		public Bill(){

		}
		public Bill(string key, string photo, int worth, string code, string history){
			this.key = key;
			this.photo = photo;
			this.worth = worth;
			this.code = code;
			this.history = history;
		}

		public Bill(Bill bill) : this(bill.key, bill.photo, bill.worth, bill.code, bill.history){}


		public override string ToString(){
			return "key: " + key + "\nphoto: "+ this.photo + "\nworth: " + this.worth + "\ncode: " + this.code + "\nhistory: " + this.history;
		}
		
	}
// }