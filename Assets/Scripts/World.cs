using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class World : MonoBehaviour
{
    [SerializeField] Player player;

    public int worldNumber;
    public int standLevel;
    public int panLevel;

    private void Start()
    {
        //TEMPORARY FOR TESTING
        worldNumber = 1;

        //DEFAULT VALUES FOR NO SAVE FILE
        standLevel = 1;
        panLevel = 1;
    }
    public World(World world)
    {   
        player.world.standLevel = world.standLevel;
        player.world.panLevel = world.panLevel;
    }
}
