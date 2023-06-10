using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private PlayerBehaviorRoot[] playerRoots;

    private void Awake()
    {
        
        playerRoots = GetComponents<PlayerBehaviorRoot>();

    }

    public void RemoveAll()
    {

        foreach(var item in playerRoots) 
        { 
            
            item.RemoveEvent();
        
        }

    }

    public void AddAll()
    {

        foreach (var item in playerRoots)
        {

            item.AddEvent();

        }

    }

}
