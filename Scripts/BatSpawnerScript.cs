using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSpawnerScript : MonoBehaviour
{
    [SerializeField] private Bat _template;
    [SerializeField] private int _creatureSpeedX;
    [SerializeField] private int _creatureSpeedY;

    public void SpawnBat()
    {
        Bat createdBat = Instantiate(_template, transform);
        createdBat.SetFlyDirection(_creatureSpeedX, _creatureSpeedY);
    }
} 
