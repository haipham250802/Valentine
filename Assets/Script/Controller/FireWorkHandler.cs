using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class FireWorkHandler : MonoBehaviour
{
    [SerializeField] FireWorkController fireWorkController;
    [SerializeField] ActiveNameController activeNameController;
    [SerializeField] float duration;
    [SerializeField] float durationStep;
    [SerializeField] float durationStepMin;
    [SerializeField] float durationStepMax;
    [SerializeField] Text txtCoolDown;
    [SerializeField] Text decs;
    [SerializeField] string str;

    private bool isSpawnBigFireWork;
    private bool Action;
    private void Start()
    {
        durationStep = Random.Range(durationStepMin, durationStepMax);
        StartCoroutine(IE_countDown());
    }
    IEnumerator IE_countDown()
    {
        yield return new WaitForSecondsRealtime(1);

        for (int i = 0; i < str.Length; i++)
        {
            yield return new WaitForSecondsRealtime(0.08f);
            decs.text += str[i].ToString();
        }
        DOTween.To(() => 1f, _ =>
        {
            decs.GetComponent<CanvasGroup>().alpha = _;
        }, 0, 1);
        yield return new WaitForSecondsRealtime(3.5f);
        txtCoolDown.text = "3";
        yield return new WaitForSecondsRealtime(1);
        txtCoolDown.text = "2";
        yield return new WaitForSecondsRealtime(1);
        txtCoolDown.text = "1";
        yield return new WaitForSecondsRealtime(1);
        txtCoolDown.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Action = true;
    }
    private void Update()
    {
        if (!Action) return;
        if (duration > 0)
        {
            duration -= Time.deltaTime;
            if (durationStep > 0) durationStep -= Time.deltaTime;
            if (durationStep < 0)
            {
                durationStep = Random.Range(durationStepMin, durationStepMax);
                SpawnFireWork();
            }
        }
        else
        {
            if (!isSpawnBigFireWork)
            {
                isSpawnBigFireWork = true;
                StartCoroutine(IESpawnBigFireWork());
                activeNameController.Active();
            }
        }
    }
    private void SpawnFireWork()
    {
        FireWorkController fireWorkControllerClone = Instantiate(fireWorkController);
        fireWorkControllerClone.OnFireWork();
    }
    private IEnumerator IESpawnBigFireWork()
    {
        yield return new WaitForSeconds(2);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        yield return new WaitForSeconds(0.1f);
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
        SpawnFireWork();
    }
}
