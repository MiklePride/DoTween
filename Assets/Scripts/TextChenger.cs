using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextChenger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _replacedText;
    [SerializeField] private string _addedText;
    [SerializeField] private string _scrambleText;
    [SerializeField] private float _duration;

    private Coroutine _coroutine;

    private void Start()
    {
        _coroutine = StartCoroutine(Chenge());
    }

    private IEnumerator Chenge()
    {
        var wait = new WaitForSeconds(_duration);

        while (enabled)
        {
            _text.DOText(_replacedText, _duration);

            yield return wait;

            _text.DOText(_addedText, _duration).SetRelative();

            yield return wait;

            _text.DOText(_scrambleText, _duration, true, ScrambleMode.All);

            yield return wait;
        }
    }
}
