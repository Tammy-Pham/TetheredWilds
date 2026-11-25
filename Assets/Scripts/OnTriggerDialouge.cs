using UnityEngine;

public class OnTriggerDialouge : MonoBehaviour
{
    public GameObject triggerbox;
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(triggerbox);
    }
}
