using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    private static BulletSpawner instance;
    public static BulletSpawner Instance { get => instance; }

    public static string bulletOne = "Bullet _1";
    public static string bulletTwo = "Bullet _2";
    protected override void Awake() 
    {
        base.Awake();
        if(BulletSpawner.instance != null) Debug.LogError("only 1 BulletSpawner allow to exit");
        BulletSpawner.instance = this;
    }
}
