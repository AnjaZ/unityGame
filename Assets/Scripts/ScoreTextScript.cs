﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
	Text text;
	public static int coinAmount;

    void Start()
    {
		text = GetComponent<Text> ();
    }

   
    void FixedUpdate()
    {
		text.text = coinAmount.ToString();
    }
}