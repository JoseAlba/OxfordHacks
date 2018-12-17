using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;
using System.IO;



public class currencyCoverter: MonoBehaviour{

	public myForex exchange; 
	// Use this for initialization


	public void Start(){
		StartCoroutine(translateLangugue());

	}
// Turn this on if you want it to work on click
	// public void FixedUpdate(){
	// 	if	(Input.GetMouseButtonUp (0)){
	// 		StartCoroutine(translateLangugue());
	// 	}
	// }


	// public string translateLanguag(){
	// 	TranslationClient client = TranslationClient.Create();
    //     var response = client.TranslateText(
    //         text: "Hello World.",
    //         targetLanguage: "ru",  // Russian
    //         sourceLanguage: "en");  // English

    //     Console.WriteLine(response.TranslatedText);
    //     return response.TranslatedText;
	// }

/*
	Method returns JSON File via get request I am using the exchangeratesapi to do this. Learn more at
	https://exchangeratesapi.io/
 */
	public IEnumerator translateLangugue() {
		
		Debug.Log ("currencyConverter");
	
		string uri = "https://api.exchangeratesapi.io/latest?base=USD";
		// string uriHistory = "https://api.exchangeratesapi.io/2010-01-12";
		// string uriSetBaseCurrency = "https://api.exchangeratesapi.io/latest?base=USD";


		var headers = new Dictionary<string, string>() {
			{ "Accept", "application/json"},
			{ "Content-Type", "application/json" }
		};

		using(WWW www = new WWW(uri, null, headers)){
			yield return www;
			// yield return null;

			string responseData = www.text; // Save the response as JSON string
	
			Debug.Log(responseData);

			GameObject.Find("speech").GetComponent<TextMesh>().text = findValue(responseData);
			exchange = JsonUtility.FromJson<myForex>(responseData);

			string jsonInfo = JsonUtility.ToJson(exchange);
			this.writeJsonData("Assets/Scripts/currency.json", jsonInfo);

			// string jsonInfo = this.toJson(exchange);
			// this.writeJsonData("Assets/Scripts/currency.json", jsonInfo);

			// string str = JsonUtility.ToJson(exchange);

			// Debug.Log(str);

			// Debug.Log(exchange);
			// Debug.Log(exchange.getBase());
			// Debug.Log(exchange.getDate());
			// Debug.Log(exchange.getRates());

			// Debug.Log("testing");
			// Debug.Log(findValue(responseData));
			// string testing = JsonUtility.ToJson(findValue(responseData));
			if (!string.IsNullOrEmpty(www.error)){
                Debug.Log(www.error);
			}
    
		    // else{
    		    // Show results as text
            	// Debug.Log(www.text);

        	    // Or retrieve results as binary data
    	    	// byte[] results = www.text;
        	// }
		};


		// using( WWW www = new WWW(uri, null, headers)){
		// 	string responseData = www.text; // Save the response as JSON string
	
		// 	Debug.Log(responseData);
	
		// 	GameObject.Find("speech").GetComponent<TextMesh>().text = findValue(responseData);

		// 	yield return www;
	        
		// 	if (!string.IsNullOrEmpty(www.error)){
        //         Debug.Log(www.error);
		// 	}
    	//     else{
    	// 	    // Show results as text
        //     	Debug.Log(www.text);

        // 	    // Or retrieve results as binary data
    	//     	// byte[] results = www.text;
        // 	}
		// }

	}

	public myForex getForex(){
		return exchange;
	}
    public string encodeURI(string unicodeString){
    //   string unicodeString = "This string contains the unicode character Pi (\u03a0)";
		byte[] data = System.Text.Encoding.ASCII.GetBytes(unicodeString);
		return data.ToString(); 
   }

	static string findValue(string responseData){
		int idx = responseData.IndexOf ("\"rates\":");
		int idx2 = responseData.IndexOf ("\"base");
		return responseData.Substring(idx + 8, idx2 - idx - 10);
	}

	public override string ToString(){
		return "myForex: " + exchange.ToString(); 
	}

    public void writeJsonData(string path, string jsonData){
		// FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write ){  
		// 	fs.Close();
		// }

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, false);
		// File.WriteAllText(@"Default\DefaultProfile.txt", String.Empty);

        writer.WriteLine(jsonData);
        writer.Close();
    }
}
