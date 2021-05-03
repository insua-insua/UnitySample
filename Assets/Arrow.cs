using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject arrowGo;
    public Transform arrowPosition;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //น฿ป็.
            Instantiate(arrowGo, arrowPosition.position, transform.rotation);
        }
    }
}
