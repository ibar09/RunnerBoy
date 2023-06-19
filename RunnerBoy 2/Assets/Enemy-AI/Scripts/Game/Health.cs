using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [Header("Health UI")]
    [SerializeField]
    public Image _healthUI;
    public GameObject FinishScene;
    private Animator anim;

    [HideInInspector] public float CurrrentHealth;

    public float _maxHealth;

    private void Start()
    {
        anim = GetComponent<Animator>();

        Debug.Log(CurrrentHealth);
        _maxHealth = CurrrentHealth;
        if (_healthUI != null)
            _healthUI.fillAmount = CurrrentHealth / _maxHealth;
    }

    public void ApplyDamage(float damage)
    {
        if (CurrrentHealth > 0)
        {
            CurrrentHealth -= damage;
            if (_healthUI != null)
                _healthUI.fillAmount = CurrrentHealth / _maxHealth;
        }
        if (CurrrentHealth == 0)
        {
            anim.Play("joo3");

            FinishScene.SetActive(true);
        }
    }
}
