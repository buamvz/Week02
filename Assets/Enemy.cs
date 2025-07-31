using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health;

    public void TakeDamage()
    {
        health -= 1;
        Debug.Log("ow");

        if (health <= 0)
        {
            Debug.Log("Enemy Ded");
        }
    }

    public void HealEnemy()
    {
        health ++;
            Debug.Log("HES ALIVE");

    }
}
