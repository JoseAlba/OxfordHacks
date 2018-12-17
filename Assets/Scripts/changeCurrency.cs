using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class changeCurrency : MonoBehaviour {
	public GameObject currencyDropdown;
	public Text currencyDropdownText;
	public string currencyDropdownValue;
	// Use this for initialization
	// public myCurrency currency;
	void Start () {
		currencyDropdownText = currencyDropdown.GetComponent<Text>();
		// currencyDropdownValue = currencyDropdownText.text;
		// currency = new myCurrency(currencyDropdownText.text);
		

		string jsonInfo = JsonUtility.ToJson(currencyDropdownText);
		this.writeJsonData("Assets/Scripts/dropdowncurrency.json", jsonInfo);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void currencyChanged(){
		currencyDropdownText = currencyDropdown.GetComponent<Text>();
		// currencyDropdownValue = currencyDropdownText.text;
		// currency = new myCurrency(currencyDropdownText.text);
		
	

		string jsonInfo = JsonUtility.ToJson(currencyDropdownText);
		Debug.Log(jsonInfo);
		Debug.Log(currencyDropdownText);
		Debug.Log(currencyDropdownText.text);
		this.writeJsonData("Assets/Scripts/dropdowncurrency.json", jsonInfo);
	}

	public void writeJsonData(string path, string jsonData){
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(jsonData);
        writer.Close();
    }
}
