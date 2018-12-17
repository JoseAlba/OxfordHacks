using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class languageDropdown : MonoBehaviour {

    public Dropdown m_Dropdown;

	// Update is called once per frame
	// void Update () {
	// 	switch(m_Dropdown.value){
	// 		case 0: this.writeJsonData("Assets/Scripts/dropdownlanguage.json", "{\"language\": \"history\"}");
	// 			break;
	// 		case 1: this.writeJsonData("Assets/Scripts/dropdownlanguage.json", "{\"language\": \"spanish\"}");
	// 			break;
	// 		case 2: this.writeJsonData("Assets/Scripts/dropdownlanguage.json", "{\"language\": \"french\"}");
	// 			break;
	// 		case 3: this.writeJsonData("Assets/Scripts/dropdownlanguage.json", "{\"language\": \"danish\"}");
	// 			break;
	// 		case 4: this.writeJsonData("Assets/Scripts/dropdownlanguage.json", "{\"language\": \"chinese\"}");
	// 			break;
	// 		case 5: this.writeJsonData("Assets/Scripts/dropdownlanguage.json", "{\"language\": \"korean\"}");
	// 			break;
	// 	}
	// }

	void Update () {
		switch(m_Dropdown.value){
			case 0: this.writeJsonData("Assets/Scripts/dropdownlanguage.dat", "history");
				break;
			case 1: this.writeJsonData("Assets/Scripts/dropdownlanguage.dat", "spanish");
				break;
			case 2: this.writeJsonData("Assets/Scripts/dropdownlanguage.dat", "french");
				break;
			case 3: this.writeJsonData("Assets/Scripts/dropdownlanguage.dat", "danish");
				break;
			case 4: this.writeJsonData("Assets/Scripts/dropdownlanguage.dat", "chinese");
				break;
			case 5: this.writeJsonData("Assets/Scripts/dropdownlanguage.dat", "korean");
				break;
		}
	}
	public void writeJsonData(string path, string jsonData){
        StreamWriter writer = new StreamWriter(path, false);    	    
		writer.WriteLine(jsonData);
       	writer.Close();
    }

}
