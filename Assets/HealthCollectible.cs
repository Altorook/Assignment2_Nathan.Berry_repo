using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : Collectible
{
    [SerializeField] private HealthManager healthManager;
    [SerializeField] private float _healAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void OnCollect()
    {
        Debug.Log("HeartCollected");
        healthManager.ChangeHealth(_healAmount);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
