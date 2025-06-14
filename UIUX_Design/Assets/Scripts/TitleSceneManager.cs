using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour, IPointerClickHandler
{
    public GameObject exitPanel;

    void Update()
    {
        if (!GetPanelActive() && Input.GetButtonDown("Cancel"))
        {
            HidePanel(true);
        }
        else if (GetPanelActive() && Input.GetButtonDown("Cancel"))
        {
            HidePanel(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        HidePanel(false);
    }

    public void HidePanel(bool hide)
    {
        exitPanel.SetActive(hide);
    }

    public void ExitButton()
    {
        HidePanel(true);
    }

    public void YesButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void NoButton()
    {
        HidePanel(false);
    }

    public bool GetPanelActive()
    {
        return exitPanel.activeSelf;
    }

    public void GoToCharacterScene()
    {
        if (!GetPanelActive())
        {
            GameSceneManager.GoToScene("CharacterScene");
        }
    }
}
