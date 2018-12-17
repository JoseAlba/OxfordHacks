using UnityEngine;
using System.Collections;
using Database;
using Vuforia;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;



public class DynamicDataSetLoader : MonoBehaviour
{
    // specify these in Unity Inspector
    public GameObject augmentationObject = null;  // you can use teapot or other object
    public string dataSetName;  //  Assets/StreamingAssets/QCAR/DataSetName

    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource audioData;
    public string jsonFile;

    private List<GameObject> _billInstances;

    Bills bills;

    public myForex exchange;

    public string currency;
    public string language;
    // Use this for initialization
    void Start()
    {
        this.jsonFile = "Assets/Scripts/Database/bills.json";
        string jsonData = this.readJsonData(this.jsonFile);
        this.bills = this.fromJson(jsonData);

        jsonFile = "Assets/Scripts/currency.json";
        jsonData = this.readJsonData(this.jsonFile);
        this.exchange = JsonUtility.FromJson<myForex>(jsonData);

        jsonFile = "Assets/Scripts/dropdownlanguage.dat";
        this.language = this.readJsonData(this.jsonFile);
        Debug.Log(this.language);

        jsonFile = "Assets/Scripts/dropdowncurrency.dat";
        this.currency = this.readJsonData(this.jsonFile);
        Debug.Log(this.currency);




        // Vuforia 6.2+
        VuforiaARController.Instance.RegisterVuforiaStartedCallback(LoadDataSet);
    }

    void LoadDataSet()
    {
        ObjectTracker objectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();

        DataSet dataSet = objectTracker.CreateDataSet();
        // Debug.Log(dataSet.ToString());
        // Debug.Log(dataSet.Load(dataSetName));

        if (dataSet.Load(dataSetName))
        {

            objectTracker.Stop();  // stop tracker so that we can add new dataset

            if (!objectTracker.ActivateDataSet(dataSet))
            {
                // Note: ImageTracker cannot have more than 100 total targets activated
                Debug.Log("<color=yellow>Failed to Activate DataSet: " + dataSetName + "</color>");
            }

            if (!objectTracker.Start())
            {
                Debug.Log("<color=yellow>Tracker Failed to Start.</color>");
            }

            int counter = 0;

            IEnumerable<TrackableBehaviour> tbs = TrackerManager.Instance.GetStateManager().GetTrackableBehaviours();
            foreach (TrackableBehaviour tb in tbs)
            {
                if (tb.name == "New Game Object")
                {

                    // change generic name to include trackable name
                    tb.gameObject.name = ++counter + ":DynamicImageTarget-" + tb.TrackableName;

                    // add additional script components for trackable
                    // tb.gameObject.AddComponent<DefaultTrackableEventHandler>();
                    tb.gameObject.AddComponent<TurnOffBehaviour>();

                    if (augmentationObject != null)
                    {
                        // instantiate augmentation object and parent to trackable
                        GameObject augmentation = (GameObject)GameObject.Instantiate(augmentationObject);
                        augmentation.transform.parent = tb.gameObject.transform;
                        augmentation.transform.localPosition = new Vector3(0f, 0f, 0f);
                        augmentation.transform.localRotation = Quaternion.identity;
                        augmentation.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
                        augmentation.gameObject.SetActive(true);

                        // if(bills.doesItExsist(tb.TrackableName))
                        // augmentation.GetComponentInChildren<Text>().text = bills.returnBill(tb.TrackableName).ToString() + exchange.ToString();
                        augmentation.GetComponentInChildren<TextMesh>().text = bills.returnBill(tb.TrackableName).ToString() + exchange.ToString();

                        mTrackableBehaviour = augmentation.GetComponent<TrackableBehaviour>();

                        // play audio source when object is registered and disable object when not active
                        if (mTrackableBehaviour)
                        {
                            mTrackableBehaviour.RegisterTrackableEventHandler(new ImageTargetPlayAudio());
                        }

                    }
                    else
                    {
                        Debug.Log("<color=yellow>Warning: No augmentation object specified for: " + tb.TrackableName + "</color>");
                    }
                }
            }
        }
        else
        {
            Debug.LogError("<color=yellow>Failed to load dataset: '" + dataSetName + "'</color>");
        }
    }

    // public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus){
    //     if (newStatus == TrackableBehaviour.Status.DETECTED ||
    //         newStatus == TrackableBehaviour.Status.TRACKED ||
    //         newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED){
    //         // Play audio when target is found
    //         audioData.Play();
    //     }
    //     else{
    //         // Stop audio when target is lost
    //         audioData.Pause();
    //     }
    // }   


    public GameObject createBillObject(Object prefab, int lengthApart)
    {
        // Object bill_prefab = Instantiate(prefab, new Vector3(2 * lengthApart, 2 * lengthApart, 2 * lengthApart), transform.rotation);
        return Instantiate(prefab, new Vector3(2 * lengthApart, 2 * lengthApart, 2 * lengthApart), transform.rotation) as GameObject;
    }

    public void exampleClass()
    {
        Bill Korean_Won = new Bill();
        Korean_Won.key = "10000_KRW_front";
        Korean_Won.photo = "10000_korean_won_front";
        Korean_Won.worth = 10000;
        Korean_Won.code = "KRW";
        Korean_Won.history = "Guy who made the Korean currency";

        Bill Koren_Won_back = new Bill("10000_KRW_back", "10000_korean_won_back", 10000, "KRW", "Some cicrle thing with handles", "french", "spanish", "danish", "chinese", "korean");
        Bill copy = new Bill(Korean_Won);

        Bills bills = new Bills(new List<Bill>() { Korean_Won, Koren_Won_back, copy });

        Debug.Log(bills);

        string player = this.toJson(bills);
        Debug.Log(player);

        bills = this.fromJson(player);
        Debug.Log(bills);

        Debug.Log("Testing");
        this.writeJsonData("Assets/Scripts/Database/bills.json", player);
        Debug.Log(this.readJsonData("Assets/Scripts/Database/bills.json"));

    }
    public string toJson(Bills bills)
    {
        return JsonHelper.ToJson(bills.ToArray(), true);
    }

    public Bills fromJson(string jsonString)
    {
        return new Bills(JsonHelper.FromJson<Bill>(jsonString));
    }

    public string readJsonData(string path)
    {
        string jsonData = "";

        StreamReader reader = new StreamReader(path);
        jsonData += reader.ReadToEnd();
        reader.Close();

        return jsonData;
    }

    public void writeJsonData(string path, string jsonData)
    {
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(jsonData);
        writer.Close();
    }

    // public override string myForexToString(){
    // 	return "myForex: " + exchange.ToString(); 
    // }

}

