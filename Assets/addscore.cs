﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addscore : MonoBehaviour
{
    public Text text;
    public GameObject text1;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void addpoint()
    {
        score++;
        text.text="socre: "+ score + "" ;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
