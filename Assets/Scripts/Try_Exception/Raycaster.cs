using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RayCasting());
    }

    IEnumerator RayCasting()
    {
        Ray ray;
        RaycastHit hit;
        while (true)
        {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Physics.Raycast(ray, out hit, Mathf.Infinity);
                if (Input.GetMouseButton(0))
                {
                    if (hit.collider.gameObject.tag == "Cube")
                    {
                        Debug.Log("상자");
                    }
                    else if (hit.collider.gameObject.tag == "Capsule")
                    {
                        Debug.Log("캡슐");
                    }
                }            
            yield return null;
        }
    }
}
