﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown(){
        Hero.S.TempFire();
        Hero.S.audio.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
