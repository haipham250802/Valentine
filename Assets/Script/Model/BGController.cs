using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class BGController : MonoBehaviour
{
    [SerializeField] Image BG;
    [SerializeField] AnimationCurve animationCurve;
   
    public void ActionAnim()
    {
        DOTween.To(() => 10f, _ =>
        {
            BG.transform.localScale = Vector3.one * _;
        }, 0.4f, 5f)
            .SetEase(animationCurve)
            .OnComplete(() =>
            {
                UIController.Instance.Views.UILoading.gameObject.SetActive(true);
                GameController.Instance.LoadingHandler.A_ShowLoading?.Invoke();
            });
    }
}
