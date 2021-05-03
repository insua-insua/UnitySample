using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        
        animator.Play("GetHit", 0, 0);

    }
}
