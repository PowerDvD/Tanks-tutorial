﻿using UnityEngine;
using System.Collections;

public class EnemyStopAndFireState : EnemyState
{

    private EnemyScript _Enemy;
    public void Enter(EnemyScript Enemy)
    {
        Debug.Log("Enter State StopAndFire");
        this._Enemy = Enemy;
        _Enemy.Shoot();
        _Enemy.SetStateIdle();
    }

    public void Exit()
    {
        Debug.Log("Exit State StopAndFire");
    }

    public void Update()
    {
        Debug.Log("Update State StopAndFire");
    }
}
