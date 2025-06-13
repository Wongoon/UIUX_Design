using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider loadingBar;
    public TextMeshProUGUI loadingText;

    private float loadTime;
    private float timer = 0f;
    private bool isLoading = true;

    void Start()
    {
        loadingBar.value = 0f;
        loadTime = Random.Range(3f, 10f);
        StartCoroutine(LoadingRoutine());
        StartCoroutine(AnimateLoadingText());
    }

    IEnumerator AnimateLoadingText()
    {
        string baseText = "Loading";
        int dotCount = 0;

        while (isLoading)
        {
            loadingText.text = baseText + new string('.', dotCount);
            dotCount = (dotCount + 1) % 4;
            yield return new WaitForSeconds(0.5f);
        }

        loadingText.text = "Loading...";
    }

    IEnumerator LoadingRoutine()
    {
        yield return new WaitForSeconds(0.5f);

        while (timer < loadTime)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / loadTime);
            float easedValue = 1f - (1f - t) * (1f - t);

            loadingBar.value = easedValue;

            yield return null;
        }

        isLoading = false;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainScene");
    }
}
