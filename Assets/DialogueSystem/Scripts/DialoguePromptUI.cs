using UnityEngine;

public class DialoguePromptUI : MonoBehaviour, IDialoguePromptUI
{
    public GameObject promptUI;
    public void promptUIActivate()
    {
        promptUI.gameObject.SetActive(true);
    }
     public void promptUIDeactivate()
    {
        promptUI.gameObject.SetActive(false);
    }
}
