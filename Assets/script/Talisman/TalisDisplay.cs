﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalisDisplay : MonoBehaviour
{
    public GameObject display;
    public float timer;
    public GameObject prefab, player;

    private float curTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space") && curTime <= 0){
			display.SetActive(true);
            curTime = timer;
		}
        if(!display.activeSelf && curTime > 0){
            curTime = 0;
        }

        if(curTime > 0){
            curTime -= Time.deltaTime;
        }
        else if(curTime <= 0 && display.activeSelf){
            display.SetActive(false);
        }
    }
}
