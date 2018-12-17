using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;
using System.IO;
using Vuforia;

public class duplicate : MonoBehaviour {

	// private int counter;
	// public GameObject billsPrefab;
	public string jsonFile;
	public GameObject imageTargetPrefab;
	private List<GameObject> _billInstances;

    // Use this for initialization
    void Start () {

		this.jsonFile = "Assets/Scripts/Database/bills.json";
		string jsonData = this.readJsonData(this.jsonFile);
		Bills bills = this.fromJson(jsonData);

		Debug.Log(bills);

		int counter = 0;
		_billInstances = new List<GameObject>();


		foreach(Bill bill in bills.bills){
			counter++;
			// GameObject bill = Instantiate(billsPrefab, new Vector3(2 * counter,2 * counter,2 * counter), transform.rotation); 
			GameObject billInstance = createBillObject(imageTargetPrefab, counter);

// TODO: modify each instance so that it gets bills ccharacteristics and it compares it to money use currencyconverter as example
			// billInstance;
			
			// billInstance.GetComponent<"Image Target Behaviour">()
			// billInstance.GetComponent<ImageTarget>().
			billInstance.GetComponentInChildren<TextMesh>().text = bill.ToString();
			// .Find("speech").GetComponent<TextMesh>().text = findValue(responseData);
			// billInstance.GetComponent(typeof(ImageTargetBehaviour)) = bill.photo;
			TrackableBehaviour bob = billInstance.GetComponent<TrackableBehaviour>();
			Debug.Log("Testing");
			Debug.Log(bob.TrackableName);
			Debug.Log("Testing");

			// ImageTargetBehaviour variableName = (ImageTargetBehaviour)billInstance.GetComponent(typeof(ImageTargetBehaviour));
			// Debug.Log(variableName);


			_billInstances.Add(billInstance);
		}



	}

	public GameObject createBillObject(Object prefab, int lengthApart){
		// Object bill_prefab = Instantiate(prefab, new Vector3(2 * lengthApart, 2 * lengthApart, 2 * lengthApart), transform.rotation);
		return Instantiate(prefab, new Vector3(2 * lengthApart, 2 * lengthApart, 2 * lengthApart), transform.rotation) as GameObject;
	}

	public void exampleClass(){
		Bill Korean_Won = new Bill();
		Korean_Won.key = "10000_KRW_front";
		Korean_Won.photo = "10000_korean_won_front";
		Korean_Won.worth = 10000;
		Korean_Won.code = "KRW";
		Korean_Won.history = "Guy who made the Korean currency";

		Bill Koren_Won_back = new Bill("10000_KRW_back","10000_korean_won_back", 10000, "KRW", "Some cicrle thing with handles", "french", "spanish", "danish", "chinese", "korean");
		Bill copy = new Bill(Korean_Won);

		Bills bills = new Bills(new List<Bill>(){Korean_Won, Koren_Won_back, copy});

		Debug.Log(bills);
		
		string player = this.toJson(bills);
		Debug.Log(player);

		bills = this.fromJson(player);
		Debug.Log(bills);

		Debug.Log("Testing");
		this.writeJsonData("Assets/Scripts/Database/bills.json", player);
		Debug.Log(this.readJsonData("Assets/Scripts/Database/bills.json"));

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
