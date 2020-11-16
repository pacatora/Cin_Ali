using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engelmatik : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    void Start()
    {
        StartCoroutine(CreateRandomObstacle());
    }

    private IEnumerator CreateRandomObstacle()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], transform.position, Quaternion.identity, transform);

        StartCoroutine(CreateRandomObstacle());
    }

}
