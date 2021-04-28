using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 place;

    public void NewHome(int x)
    {
        new Vector3(x, 0, 0);
    }
}
