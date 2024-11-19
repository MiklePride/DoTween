using DG.Tweening;

public class Scaler : Transformator
{
    private void Start()
    {
        transform.DOScale(TargetValue,Duration).SetLoops(LoopCount,LoopType);
    }
}
