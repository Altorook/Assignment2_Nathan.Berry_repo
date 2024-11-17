using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    private float playerHealth;
    private float maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeHealth(float healthAmount)
    {

        playerHealth += healthAmount;
        playerHealth = Mathf.Clamp(playerHealth, 0, maxHealth);
        Debug.Log("Health Changed By " + healthAmount +" - Player Health" + playerHealth);
    }
}
