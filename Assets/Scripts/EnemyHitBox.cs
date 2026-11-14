using UnityEngine;

public class EnemyHitBox : MonoBehaviour
{
    public EnemyHealth enemyHealth;

    private PolygonCollider2D polygonCollider;

    private void Awake()
    {
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    //lets me see the box that is the hitbox for the object
    private void OnDrawGizmos()
    {
        if(polygonCollider != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(polygonCollider.bounds.center, polygonCollider.bounds.size);

        }
    }
    //this is an on trigger of what happends when you pass through the enemy
    private void OnTriggerEnter(Collider other)
    {
        EnemyHealth enemy = other.GetComponent<EnemyHealth>();

        if(enemy != null)
        {
            enemyHealth.TakeDamage(1);
        }
    }
}
