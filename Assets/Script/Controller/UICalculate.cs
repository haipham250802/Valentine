using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class UICalculate : MonoBehaviour
{
    [SerializeField] InputField inputFields;
    [SerializeField] Button submit;
    [SerializeField] GameObject obj;
    [SerializeField] GameObject bottom;



    [SerializeField] Text text1;
    [SerializeField] string str1;

    [SerializeField] Text text2;
    [SerializeField] string str2;

    [SerializeField] Text text3;
    [SerializeField] string str3;
    
    [SerializeField] Text text4;
    [SerializeField] string str4;

    [SerializeField] Text text5;
    [SerializeField] string str5;

    [SerializeField] Text text6;
    [SerializeField] string str6;
    private void Start()
    {
        submit.onClick.AddListener(onClickButtonSubmit);
    }
    private void onClickButtonSubmit()
    {
        if(inputFields.text == "2")
        {
            bottom.SetActive(false);
            obj.transform.DOScale(0.5f, 1f);
            obj.transform.DOMove(new Vector3(-0.95f, 1.8f, 0), 1)
                .OnComplete(() =>
                {
                    StartCoroutine(ActiveText());
                });
        }
    }
    private IEnumerator ActiveText()
    {
        yield return new WaitForSecondsRealtime(1);
        for (int i = 0; i < str1.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            text1.text += str1[i].ToString();
        }
        yield return new WaitForSecondsRealtime(1);
        for (int i = 0; i < str2.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            text2.text += str2[i].ToString();
        }
        yield return new WaitForSecondsRealtime(1);
        for (int i = 0; i < str6.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            text6.text += str6[i].ToString();
        }
        yield return new WaitForSecondsRealtime(1);
        for (int i = 0; i < str3.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            text3.text += str3[i].ToString();
        }
        yield return new WaitForSecondsRealtime(1);
        for (int i = 0; i < str4.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            text4.text += str4[i].ToString();
        }
        yield return new WaitForSecondsRealtime(1);
        for (int i = 0; i < str5.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            text5.text += str5[i].ToString();
        }
    }
}
