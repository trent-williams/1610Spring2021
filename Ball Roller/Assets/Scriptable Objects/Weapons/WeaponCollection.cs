using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponCollection : MonoBehaviour
{
    public List<Weapon> weaponsList;

    public void RemoveAllWeapons()
    {
        weaponsList.Clear();
    }
}
