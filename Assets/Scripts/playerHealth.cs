using TMPro;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class playerHealth : MonoBehaviour
{
    public TMP_Text Healthtext;
    public float playerhealth = 3;
    private Coroutine flashRoutine;
    public SpriteRenderer sprite;

    //amount of damage that the enemy will take when attack 
    public void TakeDamage(float amount)
    {
        playerhealth -= amount;

        if (flashRoutine != null)
        {
            StopCoroutine(flashRoutine);

        }
        flashRoutine = StartCoroutine(FlashRed());

        if (playerhealth <= 0)
        {
            Destroy(gameObject);
        }

        Healthtext.text = $"Health {playerhealth}";
    }
    public IEnumerator FlashRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(1);
        sprite.color = Color.orange;
    }

}
