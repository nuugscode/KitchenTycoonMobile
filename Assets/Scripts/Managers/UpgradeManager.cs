using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public ToastGrill toastGrill;
    public FryerStation fryer;
    public BatteringStation battering;
    public BoardsStation plate;

    public void UpgradeToast()
    {
        toastGrill.Upgrade();
        UIManager.Instance.UpdateToastUpgradeUI(toastGrill.upgradeCost);
    }

    public void UpgradeFryer()
    {
        fryer.Upgrade();
        UIManager.Instance.UpdateFryerUpgradeUI(fryer.upgradeCost);
    }

    public void UpgradeBattering()
    {
        battering.Upgrade();
        UIManager.Instance.UpdateBatteringUpgradeUI(battering.upgradeCost);
    }

    public void UpgradePlate()
    {
        plate.Upgrade();
        UIManager.Instance.UpdatePlateUpgradeUI(plate.upgradeCost);
    }
}