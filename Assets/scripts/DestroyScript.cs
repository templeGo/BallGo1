using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyScript : MonoBehaviour {

    //public Text ClearText;

    private int itemCount;



	// Use this for initialization
	void Start () {
        //ClearText.text = "aa";
        //itemCount = 4;
        //Debug.Log(itemCount);
	}
	
	// Update is called once per frame
	void Update () {

		
        //if (itemCount == 3){
        //    ClearText.text = "Clear";

        //}
	}


    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Ball"))
        {

            // 何らかの処理
            Destroy(gameObject);
            //itemCount = itemCount - 1;
            //Debug.Log(itemCount);

        }
    }
}
