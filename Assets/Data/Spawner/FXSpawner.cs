using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : Spawner
{
    private static FXSpawner instance;
    public static FXSpawner Instance { get => instance; }

    public static string smoke1 = "Smoke_1";
    public static string bulletTwo = "Bullet _2";
    protected override void Awake() 
    {
        base.Awake();
        if(FXSpawner.instance != null) Debug.LogError("only 1 FXSpawner allow to exit");
        FXSpawner.instance = this;
    }
}
