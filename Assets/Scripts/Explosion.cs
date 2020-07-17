using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour

{
    public GameObject burst;
    public GameObject particle;

    public Transform playerPosition;
    public ParticleSystem explosion;

    private void Start()
    {
        explosion.Stop();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            burst.SetActive(true);
        }
        else
        {
            burst.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(particle, playerPosition.position, Quaternion.identity);
        }
    }
}
