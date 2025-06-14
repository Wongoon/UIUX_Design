using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircularHPMP : MonoBehaviour
{
    public Image fillImage;

    public void SetCircle(float current, float max)
    {
        float normalized = Mathf.Clamp01(current / max);
        fillImage.fillAmount = normalized;
    }
}
