using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOHelper : MonoBehaviour
{
    public float delayDestroy = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(delayDestroy > 0)
        Destroy(gameObject, delayDestroy);
    }
}
