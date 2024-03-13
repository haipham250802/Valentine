using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingHandler : MonoBehaviour
{
    public System.Action A_ShowText;
    public System.Action A_ShowLoading;
    private void Start()
    {
        A_ShowText += UIController.Instance.Views.BGController.ActionAnim;
        A_ShowLoading += UIController.Instance.Views.UILoading.OnLoading;
        LoadText();
    }
    private void LoadText()
    {
        UIController.Instance.Views.DESCController.ShowText();
    }
    private void OnDisable()
    {
        A_ShowText -= UIController.Instance.Views.BGController.ActionAnim;
        A_ShowLoading -= UIController.Instance.Views.UILoading.OnLoading;
    }
}
