using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkFlow : MonoBehaviour
{
    Slider slider;
    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    public IEnumerator Working()
    {
        float t = 0;
        while(t<1)
        {
            slider.value = t;
            t += 0.01f;
            yield return null;
        }
    }
}
