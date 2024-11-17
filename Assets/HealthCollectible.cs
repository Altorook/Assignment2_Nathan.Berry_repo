using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : Collectible
{
    [SerializeField] private float _healAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void OnCollect()
    {

        GameInfo.Instance.HealthMan.ChangeHealth(_healAmount);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
