using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset() 
    {
        this.LoadComponents();
    }

    protected virtual void Awake() 
    {
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        // for override
    }

    protected virtual void ResetValue()
    {
        //For override
    }
}
