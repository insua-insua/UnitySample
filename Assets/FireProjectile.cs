using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject arrowGo;
    public Transform arrowSpawnPosition;
    public Animator animator;
    public float fireInterval = 0.5f;
    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireInterval);
            StartCoroutine(OnFireArrow());
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(OnFireArrow());
        }
    }

    public float fireDelay = 0.2f;
    public float destroyDelay = 3f;
    private IEnumerator OnFireArrow()
    {
        
        animator.Play("Attack01", 0, 0);
       
        yield return new WaitForSeconds(fireDelay);
        
        Instantiate(arrowGo, arrowSpawnPosition.position, transform.rotation);
    }
}

