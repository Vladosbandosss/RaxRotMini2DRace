﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            GameManger.instance.IncrementScore();
        }
    }
}
