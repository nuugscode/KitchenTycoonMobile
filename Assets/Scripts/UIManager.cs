using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI upgradeCostText;

    
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
     public void UpdateMoneyUI(int amount)
    {
        moneyText.text = "$ " + amount.ToString();
    }

    public void UpdateUpgradeCostUI(int cost)
    {
        upgradeCostText.text = "Upgrade Cost: $" + cost.ToString();
    }
}
