using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currencyCoverter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FixedUpdate(){
		if	(Input.GetMouseButtonUp (0)){
			StartCoroutine(translateLangugue());
		}
	}


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
	
		string uri = "https://api.exchangeratesapi.io/latest";
		// string uriHistory = "https://api.exchangeratesapi.io/2010-01-12";
		// string uriSetBaseCurrency = "https://api.exchangeratesapi.io/latest?base=USD";


		var headers = new Dictionary<string, string>() {
			{ "Accept", "application/json"},
			{ "Content-Type", "application/json" }
		};

		using(WWW www = new WWW(uri, null, headers)){
			yield return www;

			string responseData = www.text; // Save the response as JSON string
	
			Debug.Log(responseData);
	
			GameObject.Find("speech").GetComponent<TextMesh>().text = findValue(responseData);

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
}
