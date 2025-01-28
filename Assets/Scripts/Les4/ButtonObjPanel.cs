using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonObjPanel : MonoBehaviour
{
    [SerializeField]
    public Button button;
    void Start()
    {
        button.onClick.AddListener(() =>
        {
            Debug.Log("Weapon Level UP");
        });
    }

}
