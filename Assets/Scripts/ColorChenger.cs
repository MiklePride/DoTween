using DG.Tweening;
using UnityEngine;

[RequireComponent (typeof(MeshRenderer))]
public class ColorChenger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;

    private MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_targetColor, _duration);
    }
}
