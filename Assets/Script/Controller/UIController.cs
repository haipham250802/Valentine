using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    [System.Serializable]
    public class View
    {
        [field: SerializeField] public BGController BGController;
        [field: SerializeField] public DESCController DESCController;
        [field: SerializeField] public UILoading UILoading;

    }
    #region Properites
    [field: SerializeField] public View Views;
    #endregion
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            DestroyImmediate(Instance);
    }
   
}
