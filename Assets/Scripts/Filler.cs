﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Filler : MonoBehaviour
{
    Slider slider;
    public float speed;
    Text text;
    delegate int Value();
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
        slider = GetComponent<Slider>();
        StartCoroutine(Fill(speed, (x) => IntClass.countA = x, ()=> { return IntClass.countA; }));
        StartCoroutine(Fill(speed, (x)=> IntClass.countB = x, ()=> { return IntClass.countB; }));
    }

    IEnumerator Fill(float sp, Action<int> velocity, Value value)
    {
        while(true)
        {
            float t = 0;
            while (t < 1)
            {
                t += sp;
                slider.value = t;
                text.text = sp.ToString();
                yield return new WaitForSeconds(0.01f);
            }
            velocity(value()+1);
        }

    }
}
