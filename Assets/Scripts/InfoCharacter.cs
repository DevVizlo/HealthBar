using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCharacter : MonoBehaviour
{
    private float _maxHp = 1f;
    private float _minHp = 0f;

    public float Hp;
    public float MaxHp => _maxHp;
    public float MinHp => _minHp;
}
