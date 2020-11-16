using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engelmatik : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private GameObject block;

    void Start()
    {
        StartCoroutine(CreateRandomObstacle());
    }

    void Update()
    {
        block.transform.position = new Vector3(player.transform.position.x - 2f, player.transform.position.y);
    }

    private IEnumerator CreateRandomObstacle()
    {
        yield return new WaitForSeconds(Random.Range(0.8f, 2f));
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(player.transform.position.x + 7f, -2.1f), Quaternion.identity, transform);

        StartCoroutine(CreateRandomObstacle());
    }

}
