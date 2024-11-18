using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : Collectible
{
    [SerializeField] private GameObject doorForSwitch;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void OnCollect()
    {
        doorForSwitch.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
