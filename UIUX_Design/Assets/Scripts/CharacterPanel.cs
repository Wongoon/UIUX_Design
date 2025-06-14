using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterPanel : MonoBehaviour
{
    public GameObject selectPanel;
    public GameObject createPanel;

    public GameObject warriorPanel;
    public GameObject archerPanel;
    public GameObject magicianPanel;
    public GameObject assasinPanel;

    public TextMeshProUGUI selectText;
    public TextMeshProUGUI createText;

    void Start()
    {
        OnSelectPanel();
        OnWarriorPanel();
    }

    public void OnSelectPanel()
    {
        selectPanel.SetActive(true);
        createPanel.SetActive(false);
    }

    public void OnCreatePanel()
    {
        selectPanel.SetActive(false);
        createPanel.SetActive(true);
    }
    
    private void ResetPanel()
    {
        warriorPanel.SetActive(false);
        archerPanel.SetActive(false);
        magicianPanel.SetActive(false);
        assasinPanel.SetActive(false);
    }

    public void OnWarriorPanel()
    {
        ResetPanel();
        warriorPanel.SetActive(true);

        createText.text = "전사";
    }

    public void OnArcherPanel()
    {
        ResetPanel();
        archerPanel.SetActive(true);

        createText.text = "궁수";
    }

    public void OnMagicianPanel()
    {
        ResetPanel();
        magicianPanel.SetActive(true);

        createText.text = "마법사";
    }

    public void OnAssasinPanel()
    {
        ResetPanel();
        assasinPanel.SetActive(true);

        createText.text = "도적";
    }

    public void SelectJob()
    {
        if (selectPanel.activeSelf)
        {
            PlayerInfoManager.Instance.selectedJob = selectText.text;
        }
        else
        {
            PlayerInfoManager.Instance.selectedJob = createText.text;
        }
    }
}
