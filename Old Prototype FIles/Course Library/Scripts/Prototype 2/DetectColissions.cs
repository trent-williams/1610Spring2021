﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColissions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
