using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPerso : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;

    public float vitesseDep;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        /*var depVert = Input.GetAxis("Vertical");
        var depHor = Input.GetAxis("Horizontal");

        float vitHor = depHor * vitesseDep;
        float vitVert = depVert * vitesseDep;

        Vector3 velY = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = new Vector3(vitHor, 0, vitVert).normalized;
        rb.velocity += velY;*/

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * vitesseDep;
        }

        /*Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit infoCollisionPerso;

        if (Physics.Raycast(camRay.origin, camRay.direction, out infoCollisionPerso, 5000))
        {
            Vector3 pointARegarder = infoCollisionPerso.point;//(x, y, z)
            /*gameObject.*/
            /*transform.LookAt(pointARegarder);
            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
        }*/
    }
}
