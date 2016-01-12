using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject target; // player
    Vector3 offset; // position de depart de la camera qu'on init dans start

	// Use this for initialization
	void Start () {
        offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position =  target.transform.position +  offset;
	}
}
