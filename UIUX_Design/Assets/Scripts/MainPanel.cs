using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanel : MonoBehaviour
{
    public GameObject panel;
    private bool isActive;
    public KeyCode keyCode;

    void Start()
    {
        isActive = panel.activeSelf;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel") && panel.name != "Character")
        {
            SetPanel(false);
        }
        if (Input.GetKeyDown(keyCode))
        {
            TogglePanel();
        }
    }

    public void UpPanel()
    {
        SetPanel(true);

    }

    public void DownPanel()
    {
        SetPanel(false);
    }

    public void SetPanel(bool active)
    {
        isActive = active;
        panel.SetActive(isActive);
        if (active && panel.name != "Character")
        {
            panel.transform.SetAsLastSibling();
        }
    }

    public void TogglePanel()
    {
        if (isActive)
        {
            SetPanel(false);
        }
        else
        {
            SetPanel(true);
        }
    }
}
