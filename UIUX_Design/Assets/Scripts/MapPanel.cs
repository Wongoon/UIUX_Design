using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class MapPanel : MonoBehaviour
{
    public GameObject panel;
    private bool isActive;
    public KeyCode keyCode;

    public GameObject world;
    public GameObject planet;
    public GameObject space;

    void Start()
    {
        isActive = panel.activeSelf;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
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
        if (active)
        {
            panel.transform.SetAsLastSibling();
        }
        else
        {
            ResetPanel();
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

    public void ResetPanel()
    {
        world.SetActive(true);
        planet.SetActive(false);
        space.SetActive(false);
    }

    public void PlanetPanel()
    {
        world.SetActive(false);
        planet.SetActive(true);
        space.SetActive(false);
    }

    public void SpacePanel()
    {
        world.SetActive(false);
        planet.SetActive(false);
        space.SetActive(true);
    }
}
