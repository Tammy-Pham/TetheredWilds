using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{  // Update is called once per 
    public EnemyHealth enemyhealth;
    public float attackRange = 1.5f;
    public Transform player;
    public Transform enemy;
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
                nextAttackTime = Time.time + cooldownTime;
            }
        }
    }

}
