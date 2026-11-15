using System;
using System.Collections;
using TMPro;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Rendering.MaterialUpgrader;

public class dialogueDisplay : MonoBehaviour
{
    public static dialogueDisplay instance;
    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] CanvasGroup DialogueBox;

    public static event Action OnDialogueStarted;
    public static event Action OnDialogueEnded;
    bool skipLineTriggered;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void StartDialogue(string[] dialogue, int startPosition, string name)
    {
        nameText.text = name + "...";
        DialogueBox.gameObject.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(RunDialogue(dialogue, startPosition));
    }

    IEnumerator RunDialogue(string[] dialogue, int startPosition)
    {
        skipLineTriggered = false;
        OnDialogueStarted?.Invoke();

        for(int i = startPosition; i < dialogue.Length; i++)
        {
            dialogueText.text = dialogue[i];
            while(skipLineTriggered == false)
            {
                yield return null;
            }

            skipLineTriggered = false;
        }

        OnDialogueEnded?.Invoke();
        DialogueBox.gameObject.SetActive(false);
    }

    public void SkipLine()
    {
        skipLineTriggered = true;
    }


}
