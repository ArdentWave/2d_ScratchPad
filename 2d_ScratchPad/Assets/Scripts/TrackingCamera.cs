using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingCamera : MonoBehaviour {

    [SerializeField]
    protected Transform trackingTarget;

    [SerializeField]
    float xOffset;

    [SerializeField]
    float yOffset;

    [SerializeField]
    float followSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float xTarget = trackingTarget.position.x + xOffset;
        float yTarget = trackingTarget.position.y + yOffset;

        float xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);

        transform.position = new Vector3(xNew, yNew, transform.position.z);
	}
}
