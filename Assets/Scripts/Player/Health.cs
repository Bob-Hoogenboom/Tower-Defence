using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Health : MonoBehaviour
    {
        public int PlayerHP = 100;
        private int _currentHP;


        void Start()
        {
            _currentHP = PlayerHP;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                TakeDamage(20);
            }
        }

        void TakeDamage(int damage)
        {
            _currentHP =- damage;
            Debug.Log(_currentHP);
        }
    }

}