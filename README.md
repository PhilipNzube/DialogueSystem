# Dialogue System

A dialogue system for Unity built around ScriptableObject-based dialogue configurations. It provides a way to organise conversations, load dialogue content through Addressables, and display speaker names and dialogue text through a dedicated UI.

The system separates dialogue data, interaction handling, loading, and presentation into individual components.

## Features

- **Dialogue configuration:** Define dialogue sequences using ScriptableObjects.
- **Addressable dialogue loading:** Load dialogue trees using an Addressable key.
- **Dialogue progression:** Move through a sequence of dialogue entries.
- **Speaker display:** Show the current speaker's name alongside their dialogue.
- **Interaction-based dialogue:** Start conversations through an interactable component.
- **UI separation:** Dialogue presentation is handled independently from dialogue data and loading.
- **Interfaces:** Uses interfaces to separate interaction, UI, and Addressables responsibilities.

## How it works

A dialogue conversation is represented by a `DialogueTreeConfig` ScriptableObject containing a sequence of `DialogueEntryConfig` entries.

When a player interacts with an object, `DialogueInitiator` passes the configured Addressable key to the `DialogueManager`. The dialogue loader retrieves the corresponding configuration, after which the manager begins displaying the conversation.

The player can then progress through the sequence until the dialogue ends.

## Main components

| Script | Responsibility |
|---|---|
| `DialogueManager.cs` | Loads and controls dialogue progression |
| `DialogueTreeConfig.cs` | Stores a sequence of dialogue entries |
| `DialogueEntryConfig.cs` | Defines individual dialogue entries |
| `DialogueInitiator.cs` | Starts dialogue through an interaction |
| `DialogueAddressableLoader.cs` | Loads dialogue configurations through Addressables |
| `DialoguePromptUI.cs` | Handles dialogue prompt presentation |
| `PlayerControls.cs` | Handles player-side controls |
| `IDialogueInteractable.cs` | Defines the dialogue interaction contract |
| `IDialogueAddressableLoader.cs` | Defines the dialogue loading contract |
| `IDialoguePromptUI.cs` | Defines the dialogue UI contract |

## Built with

- **Unity**
- **C#**
- **ScriptableObjects**
- **Unity Addressables**
- **TextMeshPro**
- **Unity UI**

## Getting started

Clone the repository:

```bash
git clone https://github.com/PhilipNzube/DialogueSystem.git
```

Open the project through Unity Hub and allow Unity to import the required assets and packages.

The project uses Unity Addressables, TextMeshPro, and the Universal Render Pipeline.

## Setting up a dialogue

1. Create a dialogue tree configuration using the Dialogue System asset menu.
2. Add dialogue entries to the configuration.
3. Set the speaker name and dialogue text for each entry.
4. Register the dialogue configuration with the Addressables system.
5. Assign its Addressable key to a GameObject with a `DialogueInitiator`.
6. Configure the dialogue manager and UI references in the scene.
7. Trigger the interaction to load and start the conversation.

## Project contents

The main implementation is located in:

```text
Assets/DialogueSystem/
├── Scene/
├── ScriptableObjects/
└── Scripts/
```

The repository also includes a demo dialogue scene and sample dialogue configuration assets.

## Notes

The current implementation progresses through a dialogue sequence in order. It is a straightforward foundation for conversations in games and can be extended with branching choices, dialogue conditions, quest events, or other gameplay-specific behaviour.
