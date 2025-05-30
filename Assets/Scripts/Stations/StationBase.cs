using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class StationBase : MonoBehaviour
{
    public float cooldownTime = 1f;
    private float currentCooldown = 0f;

    public int incomePerCycle = 10;
    public int upgradeLevel = 1;
    public int upgradeCost = 100;

    protected bool canCook = true;

    protected virtual void Update()
    {
        if (!canCook)
        {
            currentCooldown -= Time.deltaTime;
            if (currentCooldown <= 0f)
            {
                canCook = true;
            }
        }
    }

    public virtual void ManualCook()
    {
        if (!canCook) return;

        CurrencyManager.Instance.AddMoney(incomePerCycle);
        UIManager.Instance.UpdateMoneyUI(CurrencyManager.Instance.currentMoney);

        // Start cooldown
        canCook = false;
        currentCooldown = cooldownTime;

        Debug.Log($"{this.GetType().Name} cooked! Earned ${incomePerCycle}");
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

