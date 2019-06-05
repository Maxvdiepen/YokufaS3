﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedTestCannon : MonoBehaviour
{
    [SerializeField]
    private Transform projectileSpawnPoint;

    [SerializeField]
    GameObject projectilePrefab;

    private float lastTimestamp;

    private float timerSpeed;

    public int currentSpeed;

    public TextMesh Counter;

    private int count;

    private void Start()
    {
        timerSpeed = Random.Range(6f, 10f);
        currentSpeed = 10;
    }

    void Update()
    {
        if (currentSpeed < 21)
        {
            if (Time.time - lastTimestamp > timerSpeed)
            {
                lastTimestamp = Time.time;
                Shoot();
                count = currentSpeed - 9;
                Counter.text = count.ToString();
                Debug.Log("Current speed is " + currentSpeed);
                currentSpeed++;
                timerSpeed = Random.Range(6f, 10f);
            }
        }

    }

    public void Shoot()
    {
            Instantiate(projectilePrefab, projectileSpawnPoint.position, new Quaternion(180,0,0,0));
            
    }
}
