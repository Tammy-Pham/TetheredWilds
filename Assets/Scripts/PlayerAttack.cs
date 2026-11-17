using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{  // Update is called once per 
    public EnemyHealth enemyhealth;
    public float attackRange = 1.5f;
    public Transform player;
    private float nextAttackTime;
    [SerializeField] private float cooldownTime = 1.0f;
    [SerializeField] private LayerMask enemyLayer;


    private void Start()
    {
        

    }
    //what the player can press to attack
    //didn't find a way for how enemy diffeent attacks determine the damage
    //where there is a cool down between attacks
    //next is to have it where it does double attacks when ytou press P


    private void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("atk");
                RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector3.one*0.5f, 0, transform.right, 1.1f, enemyLayer);
                if(hit != null)
                {
                    Debug.Log("Hit box " + hit.transform.gameObject.name);
                    if (hit.transform.TryGetComponent<EnemyHealth>(out EnemyHealth enemy))
                    {
                        Debug.Log("Hit enemy");
                        enemy.TakeDamage(1);
                    }
                }
                nextAttackTime = Time.time + cooldownTime;
            }
        }
    }

    /*private void BadUpdate()
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
            if (Input.GetKeyDown(KeyCode.P) && enemyhealth != null && distance1 <= attackRange)
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
    }*/

}
