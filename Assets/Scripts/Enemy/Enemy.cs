using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Gold Settings")]
    [Tooltip("The amount of gold rewarded to the player")][SerializeField] int goldReward = 25; 
    [SerializeField] int goldPenalty = 25;

    Bank bank;

    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        if (bank ==  null) { return; }
        bank.Deposit(goldReward);
    }

    public void StealGold()
    {
        if (bank ==  null) { return; }
        bank.Withdraw(goldPenalty);
    }

}
