using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    float MovementSpeed { get; }
    float MovementSpeedWalk { get; }
    float MovementSpeedRun { get; }

    void Move(Vector3 direction);

    void ChangeSpeed();
}
