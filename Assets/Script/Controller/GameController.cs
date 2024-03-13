using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    [SerializeField] LoadingHandler loadingHandler;
    [SerializeField] HeartsController heartController;
    public LoadingHandler LoadingHandler => loadingHandler;
    public HeartsController HeartController => heartController;
    private void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            DestroyImmediate(Instance);
    }
}
