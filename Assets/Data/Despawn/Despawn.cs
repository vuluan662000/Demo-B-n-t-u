using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : SaiMonoBehaviour
{
    protected virtual void FixedUpdate() 
    {
        this.Despawning();
    }

    protected virtual void Despawning()
    {
        if(!this.CanDespawn()) return;
        this.DespawnObject();

    }
    public virtual void DespawnObject()
    {
        Debug.LogError("DespawnObject", gameObject);
        Destroy(transform.parent.gameObject);
    }

     protected abstract bool CanDespawn();
  

}
