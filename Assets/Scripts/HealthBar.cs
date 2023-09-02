using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    [SerializeField] private InfoCharacter _character;


    public void CheckHealthBar()
    {
        float target = _character.Hp / _character.MaxHp;
        _healthBar.DOFillAmount(target, _healthBar.fillAmount);
    }

    public void PlayerDamage()
    {
        float damage = 0.1f;
        _character.Hp -= damage;

        if (_character.Hp < 0)
        {
            _character.Hp = 0;
        }
    }

    public void PlayerHeal()
    {
        float heal = 0.1f;
        _character.Hp += heal;
        
        if(_character.Hp > 1)
        {
            _character.Hp = 1;
        }
    }
}
