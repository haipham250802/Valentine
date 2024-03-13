using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ActiveNameController : MonoBehaviour
{
    [SerializeField] GameObject heart;
    [SerializeField] GameObject Hai;
    [SerializeField] GameObject Mai;

    [SerializeField] GameObject image;

    [SerializeField] GameObject tu;
    [SerializeField] GameObject ta;


    [SerializeField] Text diendapan;
    [SerializeField] string strDiendapan;

    [SerializeField] GameObject bottom;

    public void Active()
    {
        StartCoroutine(IE_delayActive());
    }
    IEnumerator IE_delayActive()
    {
        yield return new WaitForSeconds(3.5f);
        image.SetActive(true);
        yield return new WaitForSeconds(1f);
        Hai.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        heart.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        Mai.SetActive(true);
        yield return new WaitForSeconds(1f);
        tu.transform.DOMoveX(-0.38f, 1f);
        ta.transform.DOMoveX(0.98f, 1f)
            .OnComplete(() =>
            {
                StartCoroutine(showTextDienDapAn());
            });
    }
    private IEnumerator showTextDienDapAn()
    {
        yield return new WaitForSecondsRealtime(1f);
        for (int i = 0; i < strDiendapan.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            diendapan.text += strDiendapan[i].ToString();
        }
        yield return new WaitForSecondsRealtime(0.5f);
        DOTween.To(() => 1f, _ =>
        {
            diendapan.GetComponent<CanvasGroup>().alpha = _;
        }, 0, 1)
            .OnComplete(() =>
            {
                diendapan.gameObject.SetActive(false);
                bottom.SetActive(true);
            });
    }
}
