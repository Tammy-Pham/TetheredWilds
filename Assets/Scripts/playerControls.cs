using System.Collections;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed = 5f;
    public float jumpforce = 2f;
    private bool isGrounded;
    public float moveInput;


    public float dashDistance = 15f;
    bool isdashing;
    float doubleTapTime;
    KeyCode lastKeyCode;
    // Update is called once per frame

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveInput = 0f;
        if (Input.GetKey(KeyCode.A)) moveInput = -1f;
        if (Input.GetKey(KeyCode.D)) moveInput = 1f;

        if ((Input.GetKeyDown(KeyCode.W) && isGrounded))
        {
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            if (Input.GetKeyDown(KeyCode.W)) Debug.Log("W pressed, grounded: " + isGrounded);
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if(doubleTapTime > Time.time && lastKeyCode == KeyCode.S)
            {
                //will only make you dash left
                StartCoroutine(Dash(-1f));
            }
            else
            {
                //delays for you to dash again
                doubleTapTime = Time.time + 0.5f;
            }

            lastKeyCode = KeyCode.S;
        }

    }

    private void FixedUpdate()
    {
        if (!isdashing)
        {
            rb.linearVelocity = new Vector2(moveInput * movespeed, rb.linearVelocity.y);
            Debug.Log(rb.linearVelocity);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (contact.normal.y > 0.5f)
            {
                isGrounded = true;
                return;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    IEnumerator Dash(float direction)
    {
        isdashing = true;
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);
        rb.AddForce(new Vector2(dashDistance * direction, 0f), ForceMode2D.Impulse);
        float gravity = rb.gravityScale;
        rb.gravityScale = 0;
        yield return new WaitForSeconds(0.4f);
        isdashing = false;
        rb.gravityScale = gravity;
    }
}
