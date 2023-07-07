using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int totalMoney;
    public World world;

    public PlayerData (Player player)
    {
        totalMoney = player.totalMoney;
        world = player.world;
    }
}
