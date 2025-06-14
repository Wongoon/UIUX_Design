using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacter : MonoBehaviour
{
    public GameObject warrior;
    public GameObject archer;
    public GameObject magician;
    public GameObject assasin;

    public GameObject warriorSkill;
    public GameObject archerSkill;
    public GameObject magicianSkill;
    public GameObject assasinSkill;

    void Start()
    {
        switch (PlayerInfoManager.Instance.selectedJob)
        {
            case "전사":
                OnWarrior();
                break;
            case "궁수":
                OnArcher();
                break;
            case "마법사":
                OnMagician();
                break;
            case "도적":
                OnAssasin();
                break;
            default:
                SceneManager.LoadScene("TitleScene");
                break;
        }
    }

    private void ResetPanel()
    {
        warrior.SetActive(false);
        archer.SetActive(false);
        magician.SetActive(false);
        assasin.SetActive(false);

        warriorSkill.SetActive(false);
        archerSkill.SetActive(false);
        magicianSkill.SetActive(false);
        assasinSkill.SetActive(false);
    }

    private void OnWarrior()
    {
        ResetPanel();
        warrior.SetActive(true);
        warriorSkill.SetActive(true);
    }

    private void OnArcher()
    {
        ResetPanel();
        archer.SetActive(true);
        archerSkill.SetActive(true);
    }

    private void OnMagician()
    {
        ResetPanel();
        magician.SetActive(true);
        magicianSkill.SetActive(true);
    }

    private void OnAssasin()
    {
        ResetPanel();
        assasin.SetActive(true);
        assasinSkill.SetActive(true);
    }
}
