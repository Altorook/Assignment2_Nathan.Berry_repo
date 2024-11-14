using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : Collectible
{
    [SerializeField] private HealthManager healthManager;
    [SerializeField] private float _damageAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void OnCollect()
    {
        Debug.Log("Trap Hit");
        healthManager.ChangeHealth(_damageAmount);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}