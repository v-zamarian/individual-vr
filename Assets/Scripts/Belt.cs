using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour {

    public float speed; //public for testing

    float start;
    RigidbodyConstraints constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;

	// Use this for initialization
	void Start () {
        start = Time.time;
        //speed = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        /* increase the speed over time
        float current = Time.time;

        if (current - start > 5.0) {
            speed += 1;
            start = current;
        }*/

        /* texture simulating belt movement, moves texture over time
        offset += new Vector2(0, 0.1f) * Time.deltaTime;
        renderer.material.SetTextureOffset("_MainTex", offset);
        */
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Object")) {
            return;
        }
        
        collision.transform.GetComponent<Rigidbody>().constraints = constraints;
    }

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Object")) {
            return;
        }

        collision.transform.GetComponent<Rigidbody>().velocity = speed * transform.right;
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Object")) {
            return;
        }

        collision.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
