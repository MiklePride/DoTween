using UnityEngine;
using DG.Tweening;

public abstract class Transformator : MonoBehaviour
{
    [SerializeField] protected Vector3 TargetValue;
    [SerializeField] protected float Duration;
    [SerializeField] protected int LoopCount;
    [SerializeField] protected LoopType LoopType;
}