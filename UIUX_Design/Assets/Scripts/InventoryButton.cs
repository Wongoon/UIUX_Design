using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryButton : MonoBehaviour
{
    public GameObject[] onButtons = new GameObject[5];
    public GameObject[] offButtons = new GameObject[5];
    // 0 : Equipment
    // 1 : Consume
    // 2 : Etc
    // 3 : Quest
    // 4 : Cash

    void Start()
    {
        ResetButton(0);
    }

    public void ResetButton(int idx)
    {
        foreach (GameObject button in onButtons)
        {
            button.SetActive(false);
        }
        foreach (GameObject button in offButtons)
        {
            button.SetActive(true);
        }

        onButtons[idx].SetActive(true);
        offButtons[idx].SetActive(false);
    }
}
