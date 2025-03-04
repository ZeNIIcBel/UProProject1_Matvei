using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntryPoint : MonoBehaviour
{
    [SerializeField] CreatePlayer createplayer;
    [SerializeField] FindCharacter[] findCharacter;
    private void Awake()
    {
        createplayer.Init();
        foreach (var enemy in findCharacter) enemy.Init();
       
    }
}
