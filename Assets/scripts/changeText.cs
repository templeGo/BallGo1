using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeText : MonoBehaviour {

    public Text ClearText;


    private GameObject[] DestroyItem;
    private int itemCount;

    void Start()
    {
        DestroyItem = GameObject.FindGameObjectsWithTag("Item");
        itemCount = DestroyItem.Length;
        Debug.Log(itemCount);

        ClearText.text = "";

    }

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        DestroyItem = GameObject.FindGameObjectsWithTag("Item");
        itemCount = DestroyItem.Length;

        if (itemCount == 0){
            ClearText.text = "Clear";
        }
		
	}
}
