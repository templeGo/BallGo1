using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour{
    

    public Text ClearText;


    // Use this for initialization
    void Start()
    {
        ClearText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball(Clone)")
        {
            ClearText.text = "Clear";
        }
    }

}
