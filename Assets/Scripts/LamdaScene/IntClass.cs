using UnityEngine;
using UnityEngine.UI;

public class IntClass: MonoBehaviour
{
    public static int countA = 1;
    public static int countB = 1;
    public Text[] texts;

    private void Update()
    {
        texts[0].text = countA.ToString();
        texts[1].text = countB.ToString();
    }
}
