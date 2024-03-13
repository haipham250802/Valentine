using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class HeartsController : MonoBehaviour
{
    [SerializeField] List<HeartItem> listImage = new();
    private void Start()
    {
        
    }
    public IEnumerator IE_ActiveHeart()
    {
        for (int i = 0; i < listImage.Count; i++)
        {
            listImage[i].ActiveHeart();
            yield return new WaitForSecondsRealtime(0.2f);
        }
        SceneManager.LoadScene(1);

    }
    public void Active()
    {
        StartCoroutine(IE_ActiveHeart());
    }
    public IEnumerator IE_DeActiveHeart()
    {
        for (int i = 0; i < listImage.Count; i++)
        {
            listImage[i].DeActiveHeart();
            yield return new WaitForSecondsRealtime(0.2f);
        }
        yield return new WaitForSecondsRealtime(1f);
    }
}
