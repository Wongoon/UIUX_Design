using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    public GameObject panel;
    private bool isActive;
    public KeyCode keyCode;

    private GameObject[] panels;

    void Start()
    {
        isActive = panel.activeSelf;
        panels = new GameObject[] {
            PanelManager.Instance.skillPanel,
            PanelManager.Instance.inventoryPanel,
            panel
        };
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel") && panels.All(panel => !panel.activeSelf))
        {
            SetPanel(true);
        }
        else if (Input.GetButtonDown("Cancel") && isActive)
        {
            SetPanel(false);
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
        if (active)
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
