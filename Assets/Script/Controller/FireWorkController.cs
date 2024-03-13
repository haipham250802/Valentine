using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FireWorkController : MonoBehaviour
{
    [SerializeField] GameObject[] trail;
    [SerializeField] GameObject[] Compact;
    [SerializeField] AudioClip[] au;
    [SerializeField] AudioSource tini;
    [SerializeField] AudioSource compact;
    public void OnFireWork()
    {
        int randTrail = Random.Range(0, trail.Length);
        int randComPact = Random.Range(0, Compact.Length);
        float X = Random.Range(-2.2f , 2.2f);
        float Y = Random.Range(2.6f, 3f);
        float duration = Random.Range(0.5f, 1f);
        float size = Random.Range(0.4f, 0.65f);
        GameObject obj = Instantiate(trail[randTrail]);
        obj.transform.SetParent(transform, false);
        obj.transform.localPosition = Vector3.zero;
        transform.position = new Vector3(X, -6, 0);
        tini.Play();
        transform.DOMoveY(Y, duration)
            .OnComplete(() =>
            {
                compact.clip = au[Random.Range(0, 2)];
                compact.Play();
                GameObject obj = Instantiate(Compact[randComPact]);
                obj.transform.SetParent(transform,false);
                obj.transform.localPosition = Vector3.zero;
                obj.transform.localScale = new Vector3(size, size, size);
            });
    }
}
