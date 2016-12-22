using UnityEngine;
using System.Collections;

public class CubeAnim : MonoBehaviour {

	public Transform center;
	public float radius = 5;
	public float angle =0;
	public float period = 6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.GetComponent<Renderer>().isVisible) {
//			print("Detected!");
			angle += period*Time.deltaTime; 
			float x = Mathf.Cos(angle)*radius + center.transform.position.x; //x=cos(angle)*R+a;
			float y = this.transform.position.y;
			float z = Mathf.Sin(angle)*radius + center.transform.position.z; //y=sin(angle)*R+b;
			this.gameObject.transform.position = new Vector3 (x,y,z);
		}
		else {
			this.gameObject.transform.position = new Vector3 (0,0,0);
		}
	}
}
