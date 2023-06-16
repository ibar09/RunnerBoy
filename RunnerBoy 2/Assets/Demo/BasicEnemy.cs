using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : MonoBehaviour
{

    public GameObject FinishScene;
    [Header("Stats")]
    public int health;

    [Header("Health UI")]
    [SerializeField]
    private Image _healthUI;



    private void Start()
    {
        health = health;
        if (_healthUI != null)
            _healthUI.fillAmount = health / health;
    }




    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            if (_healthUI != null)
                _healthUI.fillAmount = health / health;
        }
            DestroyEnemy();
        if (_healthUI != null)
            _healthUI.fillAmount = health / health;
    }

    public void DestroyEnemy()
    {
        FinishScene.SetActive(true);
        Destroy(gameObject);
    }
}