using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectible : Collectible
{
    [SerializeField] private PointManager _pointManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void OnCollect()
    {
        _pointManager.IncrementPoints();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
