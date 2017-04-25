using UnityEngine;
using System.Collections;

public class Allaudio : MonoBehaviour {

	void Awake() { 
		DontDestroyOnLoad(GameObject.Find("SoundMenu").gameObject); 
	
	}
	void Update() {
		//Destroy(GameObject.Find ("SoundMenu").gameObject);
	}
}
