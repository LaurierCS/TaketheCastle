using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] public class ChestsCollected{
    public bool chestOne;
    public bool chestTwo;
}

public class CanExitLabyrinth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChestsCollected Collected = new ChestsCollected();
        Collected.chestOne = false;
        Collected.chestTwo = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (chestOne && chestTwo) {
            // allows player to exit? sh*t i gotta code another collider f*ck me
        //}
    }
}
