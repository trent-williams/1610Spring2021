using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCountBehavior : MonoBehaviour
{
    public IntData enemyCountData;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0.2f);
        print(enemyCountData.value);
    }
}
