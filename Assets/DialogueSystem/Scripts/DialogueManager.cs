using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerNameText;
    public TextMeshProUGUI dialogueText;
    private DialogueTreeConfig currentTree;
    private int currentDialogueIndex = 0;
    public bool EndedDialogue = false;
    public IDialogueAddressableLoader dialogueAL;

    void Start()
    {
        dialogueAL = GetComponent<IDialogueAddressableLoader>();
    }


    public async void LoadDialogueTree(string addressableKey)
    {
        dialogueAL.AddressableLoader(addressableKey);
    }
    public async void OnDialogueTreeLoaded(AsyncOperationHandle<DialogueTreeConfig> obj)
    {
        await obj.Task;
        
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            currentTree = obj.Result;
            StartDialogue();
        }
    }

    public void StartDialogue()
    {
        if (currentTree.dialogueSequence.Count > 0)
        {
            DisplayDialogue(currentTree.dialogueSequence[0]);
        }
    }

    public void ProceedToNextDialogue()
    {
        currentDialogueIndex++;
        if (currentDialogueIndex < currentTree.dialogueSequence.Count)
        {
            DisplayDialogue(currentTree.dialogueSequence[currentDialogueIndex]);
        }
        else
        {
            EndDialogue();
        }
    }

    private void DisplayDialogue(DialogueEntryConfig entry)
    {
        speakerNameText.text = entry.characterName;
        dialogueText.text = entry.dialogueText;
    }


    public void EndDialogue()
    {
        currentDialogueIndex = 0; //I did this for demo purposes, cause I have very little dialogues and i want to loop through them everytime. In a real game, I dont think you would reset it to zero;
        speakerNameText.text = "";
        dialogueText.text = "";
        EndedDialogue = true;
    }
}
