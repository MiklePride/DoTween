using DG.Tweening;
using UnityEngine;

public class Rotator : Transformator
{
    [SerializeField] private RotateMode _rotateMode;

    private void Start()
    {
        transform.DORotate(TargetValue, Duration, _rotateMode).SetLoops(LoopCount, LoopType);
    }
}
