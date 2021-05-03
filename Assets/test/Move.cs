using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.1f;
    void Update()
    {
        float moveZ = 0;
        if (Input.GetKey(KeyCode.W)) moveZ = -1;
        if (Input.GetKey(KeyCode.S)) moveZ = 1;
        // W위로 A왼쪽 S아래 D오른쪽

        float moveX = 0;
        if (Input.GetKey(KeyCode.A)) moveX = 1;
        if (Input.GetKey(KeyCode.D)) moveX = -1;

        
        Vector3 position = transform.position;
        position.x = position.x + moveX * speed;
        position.z = position.z + moveZ * speed;
        transform.position = position;


        
    }
}
