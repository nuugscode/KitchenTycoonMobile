using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager : MonoBehaviour
{

    public int baseIncome = 10;
    public int incomeMultiplier = 1;

     public void CookFood()
    {
        int moneyEarned = baseIncome * incomeMultiplier;
        CurrencyManager.Instance.AddMoney(moneyEarned);
        Debug.Log("Cooked! Earned: $" + moneyEarned);
        UIManager.Instance.UpdateMoneyUI(CurrencyManager.Instance.currentMoney);
    }
}
