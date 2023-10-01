using UnityEngine;

public class DialogueCollision : MonoBehaviour, IDialogueCollision 
{

    private DialogueManager dialogueManagerInstance;
    private DialoguePromptUI DialoguePUI;
    private DialoguePromptUI2 DialoguePUI2;
    private PlayerControls playerControls;

     void Start()
    {
        // Get references to the DialogueManager and UI elements from the same GameObject.
        dialogueManagerInstance = GetComponent<DialogueManager>();
        DialoguePUI = GetComponent<DialoguePromptUI>();
        DialoguePUI2 = GetComponent<DialoguePromptUI2>();
        playerControls = GetComponent<PlayerControls>();
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IDialogueInteractable>() != null)
        {
            playerControls.objectCollidedWith = other;
            DialoguePUI.promptUIActivate();
            playerControls.dialogueEnabled = true;
            dialogueManagerInstance.EndedDialogue = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<IDialogueInteractable>() != null)
        {
            DialoguePUI.promptUIDeactivate();
            playerControls.dialogueEnabled = false;
            dialogueManagerInstance.EndDialogue();
        }
    }
}

