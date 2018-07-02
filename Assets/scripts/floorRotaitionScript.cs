using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorRotaitionScript : MonoBehaviour {

	// Use this for initialization
	
	
	// Update is called once per frame


    void Update (){
        Vector2 vector = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);
        float x = vector.x;
        float z = vector.y;


        transform.Rotate(0f, 0f, x * 2.0f);
        transform.Rotate(z * -2.0f, 0f, 0f);


	}
}
