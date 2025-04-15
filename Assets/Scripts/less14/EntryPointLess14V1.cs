using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointLess14V1 : MonoBehaviour
{
    [SerializeField]
    CharacterSettings ordinary; // Настройки для обычного персонажа
    [SerializeField]
    CharacterSettings magic; // Настройки для магического персонажа
    [SerializeField]
    CharacterSettings cowboy; // Настройки для ковбоя

    [SerializeField]
    RuntimeAnimatorController controller;
    CreatorCharacter creator = new CreatorMagic();


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            creator = new CreatorOrdinary();
            creator.CreateCharacter(ordinary, controller);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            creator = new CreatorMagic();
            creator.CreateCharacter(magic, controller);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            creator = new CreatorCowboy();
            creator.CreateCharacter(cowboy, controller);
        }
        
    }
}
