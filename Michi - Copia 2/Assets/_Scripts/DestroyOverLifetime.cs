﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverLifetime : MonoBehaviour
{

    public float lifeTime;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, lifeTime);
    }
}
