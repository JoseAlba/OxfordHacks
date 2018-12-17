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

		public Bills(string key, string photo, int worth, string code, string history, string french, string spanish, string danish, string chinese, string korean){
			bills = new List<Bill>();
			this.add(new Bill(key, photo, worth, code, history, french, spanish, danish, chinese, korean));
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

		public Boolean doesItExsist(String name){
			foreach(Bill bill in bills){
				if(bill.photo.Equals(name) || bill.key.Equals(name))
					return true;
			}

			return false;
		}

		public Bill returnBill(String name){
			foreach(Bill bill in bills){
				if(bill.photo.Equals(name) || bill.key.Equals(name))
					return bill;
			}

			return new Bill();
		}

		public void printBills(){
			foreach(Bill bill in bills){
				Debug.Log(bill.code);
				if(bill.code == null)
					Debug.Log(bill);
			}
		}
	}
}