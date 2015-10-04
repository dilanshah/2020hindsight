using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RetinaChange : MonoBehaviour {

	public List<GameObject> RetinaImages = new List<GameObject>();
	int index = 0;
	int currentInt;
	GameObject currentImage;

	void Start() {
		//make sure all Retina Images are off
		for(int i = 0; i < RetinaImages.Count; i++) {
			if(RetinaImages[i].activeInHierarchy){
				RetinaImages[i].SetActive(false);
			}
		}
		currentImage = RetinaImages[index];
		currentImage.SetActive (true);
		Debug.Log(RetinaImages.Count);
		Debug.Log("Current Level " + Application.loadedLevel);
	}
	
	void Update () {
		//if trigger button is clicked
		if(Input.GetMouseButtonDown(0)){
			ChangeToNextImage();
		}
	}

	void ChangeToNextImage(){
		currentImage.SetActive(false);
		currentInt++;

		if(currentInt < RetinaImages.Count){
//			Debug.Log ("Current Retina Image: " + currentInt);
			currentImage = RetinaImages[currentInt];
			currentImage.SetActive(true);
		}else if (currentInt == RetinaImages.Count){
			if(Application.loadedLevel == 0) {
				Application.LoadLevel(1);
			} else {
				Application.LoadLevel(0);
			}
		}
	}
}
