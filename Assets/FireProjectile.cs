using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject arrowGo;
    public GameObject arrowSpawnPosition;
    public Animator animator;
    //������ �ð� �������� projective �߻�.
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
        //���þ׼� ����
        animator.Play("Attack01", 0, 0);

        //��� �����ٰ�
        yield return new WaitForSeconds(fireDelay);

        //�ַο츦 �߻�
        Instantiate(arrowGo, arrowSpawnPosition.transform.position, transform.rotation);
    }
}

