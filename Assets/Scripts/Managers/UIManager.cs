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
    
    public TextMeshProUGUI toastUpgradeText;
    public TextMeshProUGUI fryerUpgradeText;
    public TextMeshProUGUI batteringUpgradeText;
    public TextMeshProUGUI plateUpgradeText;

    public void UpdateToastUpgradeUI(int cost) {
    toastUpgradeText.text = "Upgrade Toast Grill ($" + cost + ")";
}
    public void UpdateFryerUpgradeUI(int cost) {
    fryerUpgradeText.text = "Upgrade Fryer ($" + cost + ")";
}
    public void UpdateBatteringUpgradeUI(int cost) {
    batteringUpgradeText.text = "Upgrade Battering ($" + cost + ")";
}
    public void UpdatePlateUpgradeUI(int cost) {
    plateUpgradeText.text = "Upgrade Plate Setup ($" + cost + ")";
}
}
