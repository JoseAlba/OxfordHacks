using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class currencyDropdown : MonoBehaviour {
    public Dropdown m_Dropdown;
    // public Text m_Text;

    // void Start()
    // {
    //     //Fetch the Dropdown GameObject
    //     // m_Dropdown = GetComponent<Dropdown>();
    //     //Add listener for when the value of the Dropdown changes, to take action
    //     m_Dropdown.onValueChanged.AddListener(delegate {
    //         DropdownValueChanged(m_Dropdown);
    //     });

    //     //Initialise the Text to say the first value of the Dropdown
    //     m_Text.text = "First Value : " + m_Dropdown.value;
    // }

    // //Ouput the new value of the Dropdown into Text
    // void DropdownValueChanged(Dropdown change){

    //     m_Text.text =  "New Value : " + change.value;
	// 	string jsonInfo = JsonUtility.ToJson(change.value);
	// 	this.writeJsonData("Assets/Scripts/dropdownlanguage.json", jsonInfo);
    // }

	// void Update(){
	// 	Debug.Log(m_Dropdown.value);

	// 	switch(m_Dropdown.value){
	// 		case 0: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"USD\"}");
	// 			break;
	// 		case 1: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"BGN\"}");
	// 			break;
	// 		case 2: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"CAD\"}");
	// 			break;
	// 		case 3: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"BRL\"}");
	// 			break;
	// 		case 4: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"HUF\"}");
	// 			break;
	// 		case 5: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"DKK\"}");
	// 			break;
	// 		case 6: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"JPY\"}");
	// 			break;
	// 		case 7: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"ILS\"}");
	// 			break;
	// 		case 8: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"TRY\"}");
	// 			break;
	// 		case 9: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"RON\"}");
	// 			break;
	// 		case 10: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"GBP\"}");
	// 			break;
	// 		case 11: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"PHP\"}");
	// 			break;
	// 		case 12: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"HRK\"}");
	// 			break;
	// 		case 13: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"NOK\"}");
	// 			break;
	// 		case 14: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"ZAR\"}");
	// 			break;
	// 		case 15: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"MXN\"}");
	// 			break;
	// 		case 16: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"AUD\"}");
	// 			break;
	// 		case 17: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"USD\"}");
	// 			break;
	// 		case 18: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"KRW\"}");
	// 			break;
	// 		case 19: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"HKD\"}");
	// 			break;
	// 		case 20: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"EUR\"}");
	// 			break;
	// 		case 21: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"ISK\"}");
	// 			break;
	// 		case 22: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"CZK\"}");
	// 			break;
	// 		case 23: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"THB\"}");
	// 			break;
	// 		case 24: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"MYR\"}");
	// 			break;
	// 		case 25: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"NZD\"}");
	// 			break;
	// 		case 26: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"PLN\"}");
	// 			break;
	// 		case 27: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"CHF\"}");
	// 			break;
	// 		case 28: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"SEK\"}");
	// 			break;
	// 		case 29: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"CNY\"}");
	// 			break;
	// 		case 30: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"SGD\"}");
	// 			break;
	// 		case 31: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"INR\"}");
	// 			break;
	// 		case 32: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"IDR\"}");
	// 			break;
	// 		case 33: this.writeJsonData("Assets/Scripts/dropdowncurrency.json", "{\"currency\": \"RUB\"}");
	// 			break;		
	// 	}
	// }
void Update(){
		Debug.Log(m_Dropdown.value);

		switch(m_Dropdown.value){
			case 0: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "USD");
				break;
			case 1: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "BGN");
				break;
			case 2: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "CAD");
				break;
			case 3: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "BRL");
				break;
			case 4: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "HUF");
				break;
			case 5: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "DKK");
				break;
			case 6: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "JPY");
				break;
			case 7: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "ILS");
				break;
			case 8: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "TRY");
				break;
			case 9: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "RON");
				break;
			case 10: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "GBP");
				break;
			case 11: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "PHP");
				break;
			case 12: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "HRK");
				break;
			case 13: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "NOK");
				break;
			case 14: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "ZAR");
				break;
			case 15: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "MXN");
				break;
			case 16: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "AUD");
				break;
			case 17: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "USD");
				break;
			case 18: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "KRW");
				break;
			case 19: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "HKD");
				break;
			case 20: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "EUR");
				break;
			case 21: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "ISK");
				break;
			case 22: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "CZK");
				break;
			case 23: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "THB");
				break;
			case 24: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "MYR");
				break;
			case 25: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "NZD");
				break;
			case 26: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "PLN");
				break;
			case 27: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "CHF");
				break;
			case 28: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "SEK");
				break;
			case 29: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "CNY");
				break;
			case 30: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "SGD");
				break;
			case 31: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "INR");
				break;
			case 32: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "IDR");
				break;
			case 33: this.writeJsonData("Assets/Scripts/dropdowncurrency.dat", "RUB");
				break;		
		}
	}
	public void writeJsonData(string path, string jsonData){
        StreamWriter writer = new StreamWriter(path, false);    	    
		writer.WriteLine(jsonData);
       	writer.Close();
    }

}