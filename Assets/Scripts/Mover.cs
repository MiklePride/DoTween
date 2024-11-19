using DG.Tweening;

public class Mover : Transformator
{
    private void Start()
    {
        transform.DOMove(TargetValue, Duration).SetLoops(LoopCount, LoopType);
    }
}