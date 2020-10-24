using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    delegate bool SweepingDel();
    SweepingDel sweepingDel;
    private void Start()
    {
        sweepingDel = Sweeping;
    }
    bool Sweeping()
    {
        Debug.Log("쓸기");
        return true;
    }
    void Mopping()
    {
        Debug.Log("닦기");
    }
    IEnumerator Clean()
    {
        Sweeping();
        yield return new WaitUntil(()=>Sweeping());
    }

    
}
