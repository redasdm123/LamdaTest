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
        StartCoroutine(MakeWork());
    }

    void ShowText()
    {
        text.text = "완성";
    }

    IEnumerator MakeWork()
    {
        StartCoroutine(workFlow.Working());
        yield return new WaitUntil(() => workFlow.isFinished);
        ShowText();
    }
}
