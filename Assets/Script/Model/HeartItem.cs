using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class HeartItem : MonoBehaviour
{
    private void Awake()
    {
        
    }
    public void ActiveHeart()
    {
        Image image = GetComponent<Image>();
        DOTween.To(() => 0f, _ =>
        {
            Color color = image.color;
            color.a = _;
            image.color = color;
        }, 1, 1f)
            .SetEase(Ease.InOutSine);
    }
    public void DeActiveHeart()
    {
        Image image = GetComponent<Image>();
        DOTween.To(() => 1f, _ =>
        {
            Color color = image.color;
            color.a = _;
            image.color = color;
        }, 0, 1f)
            .SetEase(Ease.InOutSine);
    }
}
