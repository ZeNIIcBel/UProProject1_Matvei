using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonOpenBox1 : MonoBehaviour, IClickButton
{
    private GameObject Box;
    public virtual void ButtonClick()
    {
        foreach (IDoor door in Box.GetComponentsInChildren<IDoor>())
            door.OpenDoor();
    }
}
