using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Transform> points;
    public GameObject enemyGo;

    public bool isPlaying = true;
    public float spawnDelay = 1f;

    IEnumerator Start()
    {
        //int selectedIndex = Random.Range(0, points.Count);
        //Debug.Log(points[selectedIndex]);
        while(isPlaying)
        {
            int selectedIndex = Random.Range(0, points.Count);
            //Debug.Log(points[selectedIndex]);
            
            var selectedTransform = points[selectedIndex];
            Instantiate(enemyGo, selectedTransform.position, selectedTransform.rotation);

            yield return new WaitForSeconds(spawnDelay);
        }

    }


}
