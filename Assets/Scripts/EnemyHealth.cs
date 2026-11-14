using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyhealth = 3;
    private Coroutine flashRoutine;
    public SpriteRenderer sprite;
    
    //amount of damage that the enemy will take when attack 
    public void TakeDamage(float amount)
    {
        enemyhealth -= amount;

        if(flashRoutine != null)
        {
            StopCoroutine(flashRoutine);

        }
        flashRoutine = StartCoroutine(FlashRed());

        if(enemyhealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public IEnumerator FlashRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(1);
        sprite.color = Color.purple;
    }
}
