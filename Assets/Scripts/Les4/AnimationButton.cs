using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;





public class ScaleAnimation : MonoBehaviour
{
    public float scaleMin = 0.5f;
    public float scaleMax = 1.5f;
    public float duration = 1f;

    void Start()
    {
       
        transform.DOScale(scaleMax, duration)
            .OnComplete(() => transform.DOScale(scaleMin, duration))
            .SetLoops(-1, LoopType.Yoyo);
    }
}

