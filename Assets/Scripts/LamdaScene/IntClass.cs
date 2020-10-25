using UnityEngine;
using UnityEngine.UI;

public class IntClass: MonoBehaviour
{
    public static int count = 0;
    Text text;
    private void Start()
    {
        text=GetComponent<Text>();
    }
    private void Update()
    {
        text.text = count.ToString();
    }
}
