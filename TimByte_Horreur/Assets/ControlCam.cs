using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCam : MonoBehaviour {

    public float minX = -60f;
    public float maxX = 60f;
    public float minY = -360f;
    public float maxY = 360f;

    public float sensibiliterX = 15f;
    public float sensibiliterY = 15f;
    public Vector3 offset;

    public Camera cam;

    float rotY = 0f;
    float rotX = 0f;


    // Use this for initialization
    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        rotY += Input.GetAxis("Mouse X") * sensibiliterY;
        rotX += Input.GetAxis("Mouse Y") * sensibiliterX;

        rotX = Mathf.Clamp(rotX, minX, maxX);

        transform.localEulerAngles = new Vector3(0, rotY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotX, rotY, 0);

        cam.transform.position = transform.position + offset;
    }
}
