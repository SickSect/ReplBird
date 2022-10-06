using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float        minYposition, maxYposition;
    public float        timeToSpawn;
    public GameObject   pipePrefab;
    private float       timer;

    private void Update()
    {
        if (timer < 0)
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minYposition, maxYposition);
            pipe.transform.position = new Vector3(transform.position.x, rand, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
