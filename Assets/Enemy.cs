using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private SpriteRenderer sr;

    private float redColorDuration = 0.5f;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage()
    {
        sr.color = Color.red;

        Invoke(nameof(TurnWhite), redColorDuration);
    }


    private void TurnWhite()
    {
        sr.color = Color.white;
    }
}
