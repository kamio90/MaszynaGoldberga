using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMove : MonoBehaviour
{
    private float _timer = 0f;
    private float speed = 1f;
    private int phase = 0;
    
    private void FixedUpdate()
    {
        _timer += Time.fixedDeltaTime;
        if (_timer > 1f)
        {
            phase++;
            phase %= 4;
            _timer = 0f;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(0f,0f, speed * (1 - _timer));
                break;
            case 1:
                transform.Rotate(0f, 0f, -speed * _timer);
                break;
            case 2:
                transform.Rotate(0f, 0f, -speed * (1 - _timer));
                break;
            case 3:
                transform.Rotate(0f, 0f, speed * _timer);
                break;
        }
    }
}
