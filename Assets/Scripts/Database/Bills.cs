using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Database{
	[Serializable]
	public class Bills{

		public List<Bill> bills;

		public Bills(Bill bill){
			this.bills = new List<Bill>();
			this.add(bill);
		}

		public Bills(string key, string photo, int worth, string code, string history){
			bills = new List<Bill>();
			this.add(new Bill(key, photo, worth, code, history));
		}

		public Bills(List<Bill> bills){
			this.bills = bills;
		}

		public Bills(Bill[] bills){
			this.bills = new List<Bill>();
			foreach(Bill bill in bills){
				this.add(bill);
			}
		}
		public void add(Bill bill){
			bills.Add(bill);
		}
		

		public override string ToString(){
			string returnString = "";
			foreach (var bill in bills){
				returnString += bill + "\n";
			}
			return returnString;
		}

		public Bill[] ToArray(){
			return bills.ToArray();
		}
	}
}