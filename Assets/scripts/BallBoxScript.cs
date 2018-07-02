using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBoxScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}

    public Transform Ball;

    // Update is called once per frame
    void Update()
    {
        
            if (Time.frameCount % 220 == 0f)
            {
                Instantiate(Ball, (new Vector3(Random.Range(-2.0f, 2.0f), 10f, Random.Range(-2.0f, 2.0f))), transform.rotation);
            }


    }
}
