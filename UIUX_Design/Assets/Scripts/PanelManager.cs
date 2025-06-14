using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject profilePanel;
    public GameObject skillPanel;
    public GameObject inventoryPanel;
    public GameObject settingPanel;

    public static PanelManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        profilePanel.SetActive(true);
        skillPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        settingPanel.SetActive(false);
    }
}
