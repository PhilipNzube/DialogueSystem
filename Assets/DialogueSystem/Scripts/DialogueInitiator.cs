using UnityEngine;

public class DialogueInitiator : MonoBehaviour, IDialogueInteractable
{
    public string dialogueTreeAddressableKey;

    public void Interact(DialogueManager dialogueManager)
    {
        dialogueManager.LoadDialogueTree(dialogueTreeAddressableKey);
    }
}