using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPanel : MonoBehaviour
{
    public GameObject selectPanel;
    public GameObject create1Panel;

    public GameObject warriorPanel;
    public GameObject archerPanel;
    public GameObject magicianPanel;
    public GameObject assasinPanel;

    void Start()
    {
        OnSelectPanel();
        OnWarriorPanel();
    }

    public void OnSelectPanel()
    {
        selectPanel.SetActive(true);
        create1Panel.SetActive(false);
    }

    public void OnCreatePanel()
    {
        selectPanel.SetActive(false);
        create1Panel.SetActive(true);
    }

    public void OnWarriorPanel()
    {
        warriorPanel.SetActive(true);
        archerPanel.SetActive(false);
        magicianPanel.SetActive(false);
        assasinPanel.SetActive(false);
    }

    public void OnArcherPanel()
    {
        warriorPanel.SetActive(false);
        archerPanel.SetActive(true);
        magicianPanel.SetActive(false);
        assasinPanel.SetActive(false);
    }

    public void OnMagicianPanel()
    {
        warriorPanel.SetActive(false);
        archerPanel.SetActive(false);
        magicianPanel.SetActive(true);
        assasinPanel.SetActive(false);
    }

    public void OnAssasinPanel()
    {
        warriorPanel.SetActive(false);
        archerPanel.SetActive(false);
        magicianPanel.SetActive(false);
        assasinPanel.SetActive(true);
    }
}
