using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float delayTime = 2;
    private float repeatRate = 2;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delayTime, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (playerController.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
