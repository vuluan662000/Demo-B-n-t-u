using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        Debug.Log ("BulletDespawn DespawnObject", gameObject);
        BulletSpawner.Instance.Despawn(transform.parent);
    }
}
