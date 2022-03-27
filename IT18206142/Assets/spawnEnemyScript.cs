using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnEnemyScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject coinPrefab;
    public GameObject healthPrefab;
    public Transform[] points;

    Collision_Point_UI cPoint;

    int RandomOut, coinCheck, helthPicker;
    public float StartTime = 1f;
    public float IntervalTime = 1.5f;
    public int healthBonus = 15;


 
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= StartTime)
        {
            GeneratePrefabEnemy();
            StartTime = Time.time + IntervalTime;
        }
        else if (cPoint.health < 3)
        {
            IncreseHealth();
        }
    }

    public void GeneratePrefabEnemy()
    {
        RandomOut = Random.Range(0, points.Length);
        coinCheck = Random.Range(0, 2);
        helthPicker = Random.Range(0, 2);

        for (int i=0; i < points.Length; i++)
        {
            if (i != RandomOut)
            {
                Instantiate(enemyPrefab, points[i].position, Quaternion.identity);
                if(coinCheck == 1)
                {
                    Instantiate(coinPrefab, points[RandomOut].position, Quaternion.identity);
                }
            }
        }
    }

    public void IncreseHealth()
    { 
        if(helthPicker < 2)
        {
            cPoint.health = cPoint.health + healthBonus;
        }
    }
}
