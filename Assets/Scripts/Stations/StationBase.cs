using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public abstract class StationBase : MonoBehaviour
{
    public float cookTime = 3f;
    public int incomePerCycle = 10;
    public int upgradeLevel = 1;
    public int upgradeCost = 100;

    protected Coroutine cookingRoutine;

    public virtual void StartCooking()
    {
        if (cookingRoutine == null)
            cookingRoutine = StartCoroutine(CookingLoop());
    }

    private IEnumerator CookingLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(cookTime);
            CurrencyManager.Instance.AddMoney(incomePerCycle);
            UIManager.Instance.UpdateMoneyUI(CurrencyManager.Instance.currentMoney);
        }
    }

    public virtual void Upgrade()
    {
        if (CurrencyManager.Instance.SpendMoney(upgradeCost))
        {
            upgradeLevel++;
            incomePerCycle += 10;         
            upgradeCost += 100;
        }
    }
}

