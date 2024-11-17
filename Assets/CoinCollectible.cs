using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectible : Collectible
{

    // Start is called before the first frame update
    void Start()
    {
    }
    public override void OnCollect()
    {
        GameInfo.Instance.PointMan.IncrementPoints();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
