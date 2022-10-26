using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnTime = 3f;

    [SerializeField] GameObject pipe;

    float currTime = 0;

    private void FixedUpdate()
    {
        if (currTime > spawnTime)
        {
            float yPos = Random.Range(-1.97f, 2.82f);
            Vector3 newPosition = new Vector3(transform.position.x, yPos, transform.position.z);
            Instantiate(pipe, newPosition, transform.rotation);
            currTime = 0;
        }
        else
        {
            currTime += Time.deltaTime;
        }
    }
}
