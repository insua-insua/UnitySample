using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject arrowGo;
    public GameObject arrowSpawnPosition;
    public Animator animator;
    //지정한 시간 간격으로 projective 발사.
    public float interval = 0.5f;

    private IEnumerator Start()
    {
        while(true)
        {
            StartCoroutine(OnFireArrow());
            //Instantiate(arrowGo, arrowSpawnPosition.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {           
            //OnFireArrow();
            StartCoroutine(OnFireArrow());
        }
    }

    private float fireDelay = 0.2f;

    private IEnumerator OnFireArrow()
    {
        //어택액션 진행
        animator.Play("Attack01", 0, 0);

        //잠시 쉬었다가
        yield return new WaitForSeconds(fireDelay);

        //애로우를 발사
        Instantiate(arrowGo, arrowSpawnPosition.transform.position, transform.rotation);
    }
}

