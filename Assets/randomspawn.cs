using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{   
    public GameObject poopPrefab;
    public float spawnInterval = 2f;

    private float timer = 0f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnPoop();
            timer = spawnInterval;
        }
    }

    void SpawnPoop()
    {
        float randomX = Random.Range(-2.6f, 2.7f);
        Vector2 spawnPosition = new Vector2(randomX, 5.4f);
        Instantiate(poopPrefab, spawnPosition, Quaternion.identity);
    }
}
