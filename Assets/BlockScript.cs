using UnityEngine;
using System.Collections;



public class BlockScript : MonoBehaviour {
	
	public int hitsToKill;
	public int points;
	private int numberOfHits;
	
	// Use this for initialization
	void Start () {
		numberOfHits = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		
		if (collision.gameObject.tag == "Ball"){
			numberOfHits++;
			Debug.Log ("hit:"  + numberOfHits);
			if (numberOfHits == hitsToKill){
				// destroy the object
				Destroy(gameObject);
				Debug.Log ("hit");
			}
		}
	}
}