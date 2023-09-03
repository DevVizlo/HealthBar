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
}
