using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private DialogueManager dialogueManagerInstance;
    private IDialoguePromptUI DialoguePUI;
    private IDialoguePromptUI DialoguePUI2;
    public bool dialogueEnabled = false;
    public Collider objectCollidedWith;

    void Start()
    {
        // Get references to the DialogueManager and UI elements from the same GameObject.
        dialogueManagerInstance = GetComponent<DialogueManager>();
        DialoguePUI = GetComponent<DialoguePromptUI>();
        DialoguePUI2 = GetComponent<DialoguePromptUI2>();
    }

    void Update()
    {
        if (dialogueEnabled)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                DialoguePUI.promptUIDeactivate();
                DialoguePUI2.promptUIActivate();
                IDialogueInteractable dialogueObject = objectCollidedWith.gameObject.GetComponent<IDialogueInteractable>();
                if (dialogueObject != null)
                {
                    dialogueObject.Interact(dialogueManagerInstance);
                }
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                DialoguePUI2.promptUIDeactivate();
                if (!dialogueManagerInstance.EndedDialogue)
                {
                    dialogueManagerInstance.ProceedToNextDialogue();
                }
            }
        }
    }
}