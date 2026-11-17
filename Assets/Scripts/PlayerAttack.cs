using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{  // Update is called once per 
    public EnemyHealth enemyhealth;
    public float attackRange = 1.5f;
    public Transform player;
    public Transform enemy;
    public Transform enemy1;
    public Transform enemy3;
    public Transform enemy4;
    public Transform enemy5;
    public Transform enemy6;
    public Transform enemy7;
    public Transform enemy8;
    public Transform enemy9;
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
        float distance = Vector2.Distance(player.position, enemy.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                Debug.Log(enemyhealth);
                nextAttackTime = Time.time + cooldownTime;
            }
        }
        float distance1 = Vector2.Distance(player.position, enemy1.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }
        float distance2 = Vector2.Distance(player.position, enemy3.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance2 <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }

        float distance3 = Vector2.Distance(player.position, enemy4.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance3 <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }

        float distance4 = Vector2.Distance(player.position, enemy5.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance4 <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }

        float distance5 = Vector2.Distance(player.position, enemy6.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance5 <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }

        float distance6 = Vector2.Distance(player.position, enemy7.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance6 <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }

        float distance7 = Vector2.Distance(player.position, enemy8.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance7 <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }

        float distance8 = Vector2.Distance(player.position, enemy8.position);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance8 <= attackRange)
            {
                enemyhealth.TakeDamage(1);
                nextAttackTime = Time.time + cooldownTime;
            }
        }
    }

}
