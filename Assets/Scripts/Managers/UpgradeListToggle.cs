using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeListToggle : MonoBehaviour
{
    public GameObject upgradeListPanel;
    public RectTransform upgradeButton;
    public RectTransform bottomPanel;

    public float closedYPosition = -300f;

    private bool isOpen = false;

    void Start()
    {
        
        upgradeListPanel.SetActive(false);

        upgradeButton.SetParent(bottomPanel);
        upgradeButton.SetSiblingIndex(bottomPanel.childCount); 
    }

    public void ToggleUpgradeList()
    {
        isOpen = !isOpen;

        if (isOpen)
        {
            upgradeButton.SetParent(upgradeListPanel.transform);
            upgradeButton.SetSiblingIndex(0);
            upgradeListPanel.SetActive(true);
        }
        else
        {
            upgradeButton.SetParent(bottomPanel);
            upgradeButton.SetSiblingIndex(bottomPanel.childCount);
            upgradeListPanel.SetActive(false);
            
            upgradeButton.anchoredPosition = new Vector2(upgradeButton.anchoredPosition.x, -830f);
        }
    }
}
