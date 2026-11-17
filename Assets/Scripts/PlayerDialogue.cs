using UnityEngine;

public class PlayerDialogue : MonoBehaviour
{
    [SerializeField] float talkDistance = 2;
    bool inConversation;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("1,Space pressed");
            Interact();
        }
    }

    void Interact()
    {
        if (inConversation)
        {
            dialogueDisplay.instance.SkipLine();
            return;
        }
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, talkDistance);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out NPCDialgoue npc))
            {
                Debug.Log("talking to " + npc.npcName);
                dialogueDisplay.instance.StartDialogue(npc.dialogueAsset.dialogue, npc.StartPosition, npc.npcName);
                return;
            }
        }
        Debug.Log("No NPC nearby");
    }


    private void JoinCoversation()
    {
        inConversation = true;
    }

    void LeaveCoversation()
    {
        inConversation = false;
    }

    private void OnEnable()
    {
        dialogueDisplay.OnDialogueStarted += JoinCoversation;
        dialogueDisplay.OnDialogueEnded += LeaveCoversation;
    }

    private void OnDisable()
    {
        dialogueDisplay.OnDialogueStarted -= JoinCoversation;
        dialogueDisplay.OnDialogueEnded -= LeaveCoversation;
    }

}
