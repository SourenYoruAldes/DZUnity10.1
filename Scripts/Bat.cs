using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    private int _xSpeed;
    private int _ySpeed;

    private void Update()
    {
        transform.Translate(new Vector2(_xSpeed * Time.deltaTime, _ySpeed * Time.deltaTime));
    }

    public void SetFlyDirection(int xSpeed, int ySpeed)
    {
        _xSpeed = xSpeed;
        _ySpeed = ySpeed;        
    }
}
