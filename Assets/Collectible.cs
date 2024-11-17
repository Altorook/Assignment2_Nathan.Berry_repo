using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour, ICollected
{
    public UnityEvent KillOrder;
    public void IntOnCollect()
    {
        OnCollect();
        KillOrder.Invoke();
    }
    public virtual void OnCollect()
    {
        Debug.Log("Base collectible");
    }
}

