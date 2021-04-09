using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject obj;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        Instantiate(obj);
    }
}
