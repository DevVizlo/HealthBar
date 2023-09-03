using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class InteractionHealth : MonoBehaviour
{
    [SerializeField] private InfoCharacter _character;

    public void PlayerDamage()
    {
        float damage = 0.1f;
        _character.Hp -= damage;

        if (_character.Hp < _character.MinHp)
        {
            _character.Hp = _character.MinHp;
        }
    }

    public void PlayerHeal()
    {
        float heal = 0.1f;
        _character.Hp += heal;

        if (_character.Hp > _character.MaxHp)
        {
            _character.Hp = _character.MaxHp;
        }
    }
}
