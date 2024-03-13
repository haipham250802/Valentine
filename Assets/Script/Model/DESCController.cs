using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class DESCController : MonoBehaviour
{
    [SerializeField] Text descTxt;
    [SerializeField] CanvasGroup canvasGrTxt;

    [SerializeField] Text descTxt2;
    [SerializeField] CanvasGroup canvasGrTxt2;
    [SerializeField] string descStr;
    [SerializeField] string descStr2;
    private void Start()
    {
        StartCoroutine(ShowText());
    }
    public IEnumerator ShowText()
    {
        yield return new WaitForSecondsRealtime(2f);

        for (int i = 0; i < descStr2.Length; i++)
        {
            descTxt2.text += descStr2[i].ToString();
            yield return new WaitForSecondsRealtime(0.08f);
        }
        Fadetext1();
        yield return new WaitForSecondsRealtime(5f);

        for (int i = 0; i < descStr.Length; i++)
        {
            descTxt.text += descStr[i].ToString();
            yield return new WaitForSecondsRealtime(0.08f);
        }
        Fadetext();
    }
    public void Fadetext1()
    {
        DOTween.To(() => 1f, _ =>
        {
            canvasGrTxt2.alpha = _;
        }, 0, 2f);
    }
    public void Fadetext()
    {
        DOTween.To(() => 1f, _ =>
        {
            canvasGrTxt.alpha = _;
        }, 0, 2f)
            .OnComplete(() =>
            {
                GameController.Instance.LoadingHandler.A_ShowText?.Invoke();
            });
    }
}
