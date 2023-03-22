using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FlashLightBehaviour : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 lookDir;
    float angle;
    public Camera cam;
    private Rigidbody2D rb;

    Light2D flashlight;

    public GameObject followingObj;
    private float distanceX;
    private float distanceY;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

		flashlight = GetComponent<Light2D> ();

    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyUp (KeyCode.F)) {
			flashlight.enabled = !flashlight.enabled;
		}



        distanceX = followingObj.transform.position.x - transform.position.x;
        distanceY = followingObj.transform.position.y - transform.position.y;
        Vector2 newPos = new Vector2(followingObj.transform.position.x, followingObj.transform.position.y);
        transform.position = newPos;
    }

    void FixedUpdate()
    {
        lookDir = mousePos - rb.position;
        angle = Mathf.Atan2(lookDir.y,lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    
}
