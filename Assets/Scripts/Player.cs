using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int totalMoney;
    public World world;

    public void savePlayer()
    {
        SaveLoadSystem.savePlayer(this);
    }
    public void loadPlayer()
    {
        PlayerData data = SaveLoadSystem.loadPlayer();
        totalMoney = data.totalMoney;
        world = data.world;
    }
}
