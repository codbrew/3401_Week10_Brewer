﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    public float delay = 3f;
    public GameObject explosionEffect;
    public GameObject smokeEffect;
    float countdown;
    bool hasExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && ! hasExploded )
        {
            Explode();
           
            hasExploded = true;
            
           
            
        }
        void Explode()
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(smokeEffect);
            
        }
        
    }
}
