﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    //This class manages varaibles in the game scene and for the overall run.
    public int currentFloor = 0; //Keeps track of what floor player is on
    public GameObject game; //Grabs Game GameObject to spawn new object and use other data
    public GameObject miniMap; //Grabs Minimap GameObject to spawn new objects and use other data
    public GameObject[] floorGenerationTools;
    private void Start()
    {
        EventManager.current.onFloorGeneration += onProgressingFloor;
        EventManager.current.onGameRunStart += onInitialFloorGen;
        EventManager.current.GameRunStart();

    }
    void onProgressingFloor()
    {
        currentFloor++;
    }
    void onInitialFloorGen(){
        Instantiate(floorGenerationTools[2], game.transform); //Spawn Intial Room Folder for 1st Floor Spawns
        Instantiate(floorGenerationTools[1], miniMap.transform); //Spawn Initial PlayerNode
        Instantiate(floorGenerationTools[0], miniMap.transform); //spawn initial StartRoom on Minimap
    }
}
