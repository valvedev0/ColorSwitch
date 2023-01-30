using UnityEngine;

public class rotator : MonoBehaviour {


	public float speed  = 100.0f;


	
	void Update () {
		 
		transform.Rotate(0f,0f,speed*Time.deltaTime);
	
	}
}
