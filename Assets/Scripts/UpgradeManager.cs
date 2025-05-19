using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
   public int upgradeCost = 100; 
   public int incomeBoost = 1;

   public void UpgradeCooking()
   {
    if (CurrencyManager.Instance.SpendMoney(upgradeCost))
        {
            CookingManager cooking = FindObjectOfType<CookingManager>();
            cooking.incomeMultiplier += incomeBoost;

            upgradeCost += 100; 
            UIManager.Instance.UpdateUpgradeCostUI(upgradeCost);
            UIManager.Instance.UpdateMoneyUI(CurrencyManager.Instance.currentMoney);

            Debug.Log("Upgraded! New multiplier: " + cooking.incomeMultiplier);
       }
       else
        {
            Debug.Log("Not enough money to upgrade!");
        }
   }
}
