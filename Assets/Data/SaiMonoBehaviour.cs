using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset() 
    {
        this.LoadComponents();
        this.ResetValue();
    }

    protected virtual void Awake() 
    {
        this.LoadComponents();
        //this.ResetValue();
    }

    protected virtual void LoadComponents()
    {
        // for override
    }

    protected virtual void ResetValue()
    {
        //For override
    }

    protected virtual void Start()
    {
        //For override
    }

    protected virtual void OnEnable()
    {
        //For override
    }

    protected virtual void OnDisable()
    {
        //For override
    }
}
