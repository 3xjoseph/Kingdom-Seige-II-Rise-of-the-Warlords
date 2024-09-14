using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    
    [Tooltip("Adds amount to max hit points when enemy dies")]
    [SerializeField] int difficultyRamp = 1;
    int currentHitPoints = 0; 

    Enemy enemy;

    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    void Start() 
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other) 
    {
        if (currentHitPoints <= 0)
        {
            KillEnemy();
            maxHitPoints += difficultyRamp;
            enemy.RewardGold();
        }
        ProcessHit();
    }

    void KillEnemy()
    {
        gameObject.SetActive(false);
    }

    void ProcessHit()
    {
        currentHitPoints --;

    }
}
