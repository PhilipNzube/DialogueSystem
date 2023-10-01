using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Dialogue System/DialogueTreeConfig")]
public class DialogueTreeConfig : ScriptableObject
{
    public List<DialogueEntryConfig> dialogueSequence;
}
