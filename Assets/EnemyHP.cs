using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health = 10;
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.name == "Hitbox Sword")
        {
            PlayerWeapon weapon = other.GetComponentInParent<PlayerWeapon>();
            health -= weapon.Damage;
            if (health <= 0)
            {
                Destroy(enemy);
            }
        }
    }
}