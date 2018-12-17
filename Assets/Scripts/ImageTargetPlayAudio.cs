using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetPlayAudio : MonoBehaviour,ITrackableEventHandler{
    private TrackableBehaviour mTrackableBehaviour;
	public AudioSource audioData;
    void Start(){
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour){
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

		// audioData = GetComponent<AudioSource>();
    }
     
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus){
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED){
            // Play audio when target is found
            audioData.Play();
            this.gameObject.SetActive(true);

        }
        else{
            // Stop audio when target is lost
            audioData.Pause();
            this.gameObject.SetActive(false);
        }
    }   
}