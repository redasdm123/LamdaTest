using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkFinish : MonoBehaviour
{
    WorkFlow workFlow;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        workFlow = FindObjectOfType<WorkFlow>();
        MakeWork();
    }

    void ShowText()
    {
        text.text = "완성";
    }

    void MakeWork()
    {
        StartCoroutine(workFlow.Working());
        ShowText();
    }
}
