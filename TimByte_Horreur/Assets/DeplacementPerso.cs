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
        var depVert = Input.GetAxis("Vertical");
        var depHor = Input.GetAxis("Horizontal");

        float vitHor = -depHor * vitesseDep;
        float vitVert = depVert * vitesseDep;

        transform.position += new Vector3(vitVert, 0, vitHor) * Time.deltaTime;

        if (vitHor != 0 || vitVert != 0)
        {
            anim.SetBool("Marche", true);
        }
        else {
            anim.SetBool("Marche", false);
        }
    }
}
