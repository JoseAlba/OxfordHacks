using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;
using System.IO;

public class duplicate : MonoBehaviour {

	// private int counter;
	// public GameObject billsPrefab;
	public string jsonFile;


    // Use this for initialization
    void Start () {
		jsonFile = "Assets/Scripts/Database/bills.json";
		
		string jsonData = this.readJsonData("Assets/Scripts/Database/bills.json");
		Bills bills = this.fromJson(jsonData);

		int counter = 0;		

		//TODO: work on Instantiating each GameObject so it reads it from the file
		foreach(Bill bill in bills.bills){
			// GameObject bills = Instantiate(billsPrefab, new Vector3(2 * counter,2 * counter,2 * counter), transform.rotation); 

		}
		counter ++;

	}

	public void exampleClass(){
		Bill Korean_Won = new Bill();
		Korean_Won.key = "10000_KRW_front";
		Korean_Won.photo = "10000_korean_won_front";
		Korean_Won.worth = 10000;
		Korean_Won.code = "KRW";
		Korean_Won.history = "Guy who made the Korean currency";

		Bill Koren_Won_back = new Bill("10000_KRW_back","10000_korean_won_back", 10000, "KRW", "Some cicrle thing with handles");
		Bill copy = new Bill(Korean_Won);

		Bills bills = new Bills(new List<Bill>(){Korean_Won, Koren_Won_back, copy});

		Debug.Log(bills);
		
		string player = this.toJson(bills);
		Debug.Log(player);

		bills = this.fromJson(player);
		Debug.Log(bills);

		Debug.Log(this.readJsonData("Assets/Scripts/Database/bills.json"));
		Debug.Log("Testing");
		this.writeJsonData("Assets/Scripts/Database/bills.json", player);
	}
	public string toJson(Bills bills){
		return JsonHelper.ToJson(bills.ToArray(), true);
	}

	public Bills fromJson(string jsonString){
		return new Bills( JsonHelper.FromJson<Bill>(jsonString));
	}

    public string readJsonData(string path){
		string jsonData = "";

        StreamReader reader = new StreamReader(path); 
		jsonData += reader.ReadToEnd();
        reader.Close();

		return jsonData;
    }

    public void writeJsonData(string path, string jsonData){
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(jsonData);
        writer.Close();
    }
}
