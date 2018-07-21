using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingSprite : MonoBehaviour {

    public Sprite regular, alternative;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void switchSprite(bool alt)
    {
        if (alt)
        {
            GetComponent<SpriteRenderer>().sprite = alternative;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = regular;
        }
    }
}
