using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCtrl : SaiMonoBehaviour
{
    [SerializeField] protected ItemDespawn itemDespawn;
    public ItemDespawn ItemDespawn => itemDespawn;

    [SerializeField] protected ItemInventory itemInventory;
    public ItemInventory ItemInventory => itemInventory;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemDespawn();
    }

    protected virtual void LoadItemDespawn()
    {
        if (this.itemDespawn != null) return;
        this.itemDespawn = transform.GetComponentInChildren<ItemDespawn>();
        Debug.Log(transform.name + ": LoadItemDespawn", gameObject);
    }
    public virtual void SetItemInventory(ItemInventory itemInventory)
    {
        this.itemInventory = itemInventory;
    }
}
