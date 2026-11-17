using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public Vector2 Direction;
    public float speed;
    private int currentPointIndex = 0;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Direction = waypoints[currentPointIndex].position - transform.position;
        rb.linearVelocity =Direction.normalized * speed;

        if(Vector2.Distance(transform.position, waypoints[currentPointIndex].position) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % waypoints.Length;
        }


    }

}
