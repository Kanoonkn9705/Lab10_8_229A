using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    public int healthIncrease;

    private void Start()
    {
         healthIncrease = 20;
    }

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(healthIncrease); 
    }
}
