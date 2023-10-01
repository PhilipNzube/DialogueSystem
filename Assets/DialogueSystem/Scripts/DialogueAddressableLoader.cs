using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using System.Collections.Generic;
using System.Threading.Tasks;

public class DialogueAddressableLoader : MonoBehaviour, IDialogueAddressableLoader
{
    public DialogueManager DM;

    void Start()
    {
        DM = GetComponent<DialogueManager>();
    }
    public async Task AddressableLoader(string addressableKey)
    {
        Addressables.LoadAssetAsync<DialogueTreeConfig>(addressableKey).Completed += DM.OnDialogueTreeLoaded;
    }
}