using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public playerHealth playerhealth;
    public float attackRange = 1.5f;
    public Transform enemy;
    public Transform player;
    private float nextAttackTime;
    [SerializeField] private float cooldownTime = 1.0f;

    private void Start()
    {


    }
    //what the player can press to attack
    //didn't find a way for how enemy diffeent attacks determine the damage
    //where there is a cool down between attacks
    //next is to have it where it does double attacks when ytou press P

    private void Update()
    {
        float distance = Vector2.Distance(enemy.position, player.position);
        if (Time.time >= nextAttackTime)
        {
            if (playerhealth != null && distance <= attackRange)
            {
                playerhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }
    }

}
