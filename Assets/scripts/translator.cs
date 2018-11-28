using UnityEngine;
using UnityEngine.Networking;
using System.Collections.Generic;
using System.Collections;

// using Google.Cloud.Translation.V2;

// https://translate.google.com/?hl=en&tab=wT&authuser=0#auto/es/hello%2C%20my%20name%20is%20jose%20alba
public class translator : MonoBehaviour {
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

	public IEnumerator translateLangugue() {
		
		Debug.Log ("translateLanguage()");

// TODO: Once this part works we can just grab information from button that was activated 
		string sourceText = "Testing this is english";

	//	string my_autorization = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzY29wZSI6Imh0dHBzOi8vZGV2Lm1pY3Jvc29mdHRyYW5zbGF0b3IuY29tLyIsInN1YnNjcmlwdGlvbi1pZCI6IjJjZGIxZGYyOTk2OTQzZWE5NDdjMTYyNjg0NmMyMWNjIiwicHJvZHVjdC1pZCI6IlNwZWVjaFRyYW5zbGF0b3IuRjAiLCJjb2duaXRpdmUtc2VydmljZXMtZW5kcG9pbnQiOiJodHRwczovL2FwaS5jb2duaXRpdmUubWljcm9zb2Z0LmNvbS9pbnRlcm5hbC92MS4wLyIsImF6dXJlLXJlc291cmNlLWlkIjoiL3N1YnNjcmlwdGlvbnMvNTZjODkyNjctZmYxZC00N2FkLTgzYTAtZWZkZmZhZmNjZThjL3Jlc291cmNlR3JvdXBzL1Zpc3VhbFRyYW5zbGF0b3IvcHJvdmlkZXJzL01pY3Jvc29mdC5Db2duaXRpdmVTZXJ2aWNlcy9hY2NvdW50cy9Kb3NlIiwiaXNzIjoidXJuOm1zLmNvZ25pdGl2ZXNlcnZpY2VzIiwiYXVkIjoidXJuOm1zLm1pY3Jvc29mdHRyYW5zbGF0b3IiLCJleHAiOjE1MTE2NjcyODJ9.VeTQBeNtlhpoSGbtPvqDXCHFHZZsqJWETyindBKvOdE";
		
		// const string subscriptionKey = "aasdfasdftesting";
		string sourceLanguage = "en-US";
		string targetLanguage = "es-CO";

	
		string uriBase = "https://translate.googleapis.com/translate_a/single";
		// string requestParameters = "text="+ translatingString +"from="+ from +"&to="+ to;
		string requestParameters = "client=gtx&sl=" + sourceLanguage + "&tl=" + targetLanguage + "&dt=t&q=" + encodeURI(sourceText);

		string uri = uriBase + "?" + requestParameters;

		var headers = new Dictionary<string, string>() {
			{ "text", sourceText},
//			{ "Authorization", "Bearer "+ StartCoroutine(getAuthoizationKey)},
			{ "UserAgent", "Mozilla/5.0"},
			{ "AcceptCharset", "UTF-8"},
			{ "Content-Type", "application/json" }
			// { "Content-Type", "application/octet-stream" }
		};

		using(WWW www = new WWW(uri, null, headers)){
		yield return www;

		string responseData = www.text; // Save the response as JSON string
	
		Debug.Log(responseData);
	
		// GameObject.Find("speech").GetComponent<TextMesh>().text = findValue(responseData);
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
		int idx = responseData.IndexOf ("\"text\":");
		int idx2 = responseData.IndexOf ("\"confidence");
		return responseData.Substring(idx + 8, idx2 - idx - 10);
	}
}

	// static string JsonPrettyPrint(string json)
	// {
	// 	if (string.IsNullOrEmpty(json))
	// 		return string.Empty;

	// 	json = json.Replace(Environment.NewLine, "").Replace("\t", "");

	// 	StringBuilder sb = new StringBuilder();
	// 	bool quote = false;
	// 	bool ignore = false;
	// 	int offset = 0;
	// 	int indentLength = 3;

	// 	foreach (char ch in json)
	// 	{
	// 		switch (ch)
	// 		{
	// 		case '"':
	// 			if (!ignore) quote = !quote;
	// 			break;
	// 		case '\'':
	// 			if (quote) ignore = !ignore;
	// 			break;
	// 		}

	// 		if (quote)
	// 			sb.Append(ch);
	// 		else
	// 		{
	// 			switch (ch)
	// 			{
	// 			case '{':
	// 			case '[':
	// 				sb.Append(ch);
	// 				sb.Append(Environment.NewLine);
	// 				sb.Append(new string(' ', ++offset * indentLength));
	// 				break;
	// 			case '}':
	// 			case ']':
	// 				sb.Append(Environment.NewLine);
	// 				sb.Append(new string(' ', --offset * indentLength));
	// 				sb.Append(ch);
	// 				break;
	// 			case ',':
	// 				sb.Append(ch);
	// 				sb.Append(Environment.NewLine);
	// 				sb.Append(new string(' ', offset * indentLength));
	// 				break;
	// 			case ':':
	// 				sb.Append(ch);
	// 				sb.Append(' ');
	// 				break;
	// 			default:
	// 				if (ch != ' ') sb.Append(ch);
	// 				break;
	// 			}
	// 		}
	// 	}

	// 	return sb.ToString().Trim();
	// }
