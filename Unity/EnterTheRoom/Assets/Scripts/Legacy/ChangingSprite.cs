using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing; 

public class ChangingSprite : MonoBehaviour {

    public Sprite regular, alternative;

    PostProcessingBehaviour high;
    public GameObject test;

	// Use this for initialization
	void Start () {
       // test = GameObject.FindGameObjectWithTag("MainCamera");
        high = test.GetComponent<PostProcessingBehaviour>();
        
       // ("Camera (eye)").GetComponent<PostProcessingBehaviour>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void switchSprite(bool alt)
    {
        if (alt)
        {
            GetComponent<SpriteRenderer>().sprite = alternative;
            high.enabled = true; 
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = regular;
            high.enabled = false;

        }
    }
}
