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
    [SerializeField] private LayerMask PlayerLayer;
    [SerializeField] EnemyMovement move;

    private void Start()
    {
        move = GetComponent<EnemyMovement>();

    }
    //what the player can press to attack
    //didn't find a way for how enemy diffeent attacks determine the damage
    //where there is a cool down between attacks
    //next is to have it where it does double attacks when ytou press P

    private void Update()
    {
        if (Time.time >= nextAttackTime)
        {
                Debug.Log("atk");
                RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector3.one * 0.5f, 0, transform.right * move.Direction.x, 1.1f, PlayerLayer);
            Debug.DrawLine(transform.position, transform.position + transform.right * move.Direction.x);
                if (hit != null)
                {
                    Debug.Log("Hit box " + hit.transform.gameObject.name);
                    if (hit.transform.TryGetComponent<playerHealth>(out playerHealth player))
                    {
                        Debug.Log("Hit player");
                        player.TakeDamage(1);
                    }
                }
                nextAttackTime = Time.time + cooldownTime;
        }
    }

}
