using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteraction : MonoBehaviour {

    public float MouseInteractionRange;
    private Ray ray;

	// Use this for initialization
	void Start () {
        ray = new Ray();

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        
	}

    public GameObject Click()
    {
        ray.origin = transform.position;
        ray.direction = GetComponent<Camera>().transform.forward;

        RaycastHit hit;
        GameObject obj = null;

        if (Physics.Raycast(ray, out hit))
            {
                obj = hit.collider.gameObject;
            }
        if (obj != null)
        {
            return obj;
        }
        else return null;
    }

    //public GameObject SpecialClick()
    //{

    //}
}
