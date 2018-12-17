using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class changeLanguage : MonoBehaviour {
	public GameObject languageDropdown;
	public Text languageDropdownText;
	public string languageDropdownValue;

	// public ChoosenLanguage language;
	// Use this for initialization
	void Start () {
		languageDropdownText = languageDropdown.GetComponent<Text>();
		// language = new ChoosenLanguage(languageDropdownText.text);

		string jsonInfo = JsonUtility.ToJson(languageDropdownText);
		this.writeJsonData("Assets/Scripts/dropdownlanguage.json", jsonInfo);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void lanageChanged(){
		languageDropdownText = languageDropdown.GetComponent<Text>();
		// language = new ChoosenLanguage(languageDropdownText.text);

		string jsonInfo = JsonUtility.ToJson(languageDropdownText);
		this.writeJsonData("Assets/Scripts/dropdownlanguage.json", jsonInfo);
	}

	public void writeJsonData(string path, string jsonData){
        StreamWriter writer = new StreamWriter(path, false);    	    
		writer.WriteLine(jsonData);
       	writer.Close();
    }
}
