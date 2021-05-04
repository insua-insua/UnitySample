using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - offset;
    }
}
