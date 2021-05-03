using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            Time.timeScale *= 0.5f;

        if (Input.GetKeyDown(KeyCode.C))
            Time.timeScale *= 2f;
        
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }
    }
}
