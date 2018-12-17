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
		public string french;
		public string spanish; 
		public string danish;
		public string chinese;
		public string korean;

		public Bill(){

		}
		public Bill(string key, string photo, int worth, string code, string history, string french, string spanish, string danish, string chinese, string korean){
			this.key = key;
			this.photo = photo;
			this.worth = worth;
			this.code = code;
			this.history = history;
			this.french = french;
			this.spanish = spanish;
			this.danish = danish;
			this.chinese = chinese;
			this.korean = korean;
		}

		public Bill(Bill bill) : this(bill.key, bill.photo, bill.worth, bill.code, bill.history, bill.french, bill.spanish, bill.danish, bill.chinese, bill.korean){}


		public override string ToString(){
			return "key: " + this.key + "\nphoto: "+ this.photo + "\nworth: " + this.worth + "\ncode: " + this.code + "\nhistory: " + this.history +
			"\nfrench: " + this.french + "\nspanish: " + this.spanish + "\ndanish: " + this.danish + "\nchinese: " + this.chinese + "\nkorean: " + this.korean +"\n";
		}
		// public string getLanguage(string language){
		// 	if(language.Equals("history")){
		// 		return this.history;
		// 	}
		// 	if(language.Equals("spanish")){
		// 		return this.spanish;
		// 	}
		// 	if(language.Equals("french")){
		// 		return this.french;
		// 	}
		// 	if(language.Equals("danish")){
		// 		return this.history;
		// 	}
		// 	if(language.Equals("chinese")){
		// 		return this.history;
		// 	}
		// 	if(language.Equals("korean")){
		// 		return this.history;
		// 	}
		// 	return "Not a proper option";

		// }

		public string getLanguage(string language){
			language.Replace(@"[^\u0009\u000A\u000D\u0020-\u007E]", string.Empty);

			// string onlyLetters = new String(language.Where(Char.IsLetter).ToArray());

			// Debug.Log(language);
			// Debug.Log("history");
			if(language == "history"){
				return this.history;
			}
			if(language == "spanish"){
				return this.spanish;
			}
			if(language == "french"){
				return this.french;
			}
			if(language == "danish"){
				return this.history;
			}
			if(language == "chinese"){
				return this.history;
			}
			if(language == "korean"){
				return this.history;
			}
			return "Not a proper option";

		}
	}
// }