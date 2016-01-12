using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

    public GameObject fire;
    public float fireRate;
    public float fireForce = 5000;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = new Vector3(0, 0, transform.localScale.z);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject f = Instantiate(fire, 
                                       transform.position + offset, 
                                       transform.rotation) as GameObject;
            f.GetComponent<Rigidbody>().AddForce(transform.rotation * new Vector3(0, 0, fireForce));
        }
	}
}
