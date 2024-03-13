using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class UILoading : MonoBehaviour
{
    [SerializeField] private Image Fill;
    [SerializeField] private Text txt;
    [SerializeField] private AnimationCurve animationCurve;

    public void OnLoading()
    {
        DOTween.To(() => 0f, _ =>
        {
            Fill.fillAmount = _;
            txt.text = $"Loving {_ * 100}%";
        }, 1, 10f)
            .SetEase(animationCurve)
            .OnComplete(() =>
        {
            GameController.Instance.HeartController.Active();
        });
    }
}
