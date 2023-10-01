using UnityEngine;

public class DialoguePromptUI2 : MonoBehaviour, IDialoguePromptUI
{
    public GameObject promptUI2;
    public void promptUIActivate()
    {
        promptUI2.gameObject.SetActive(true);
    }
     public void promptUIDeactivate()
    {
        promptUI2.gameObject.SetActive(false);
    }
}
