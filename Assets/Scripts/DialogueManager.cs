using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public List<Dialogue> dialogueList = new List<Dialogue>();

    public float charDelay;

    private Dialogue curentDialogue;
    private int dialogueIndex = 0;

    private void Start()
    {
        if(curentDialogue == null && dialogueList.Count > 0)
        {
            LoadDialogueByIndex(0);
        }
    }


    public void GenerateTextByChar()
    {
        StartCoroutine(curentDialogue.ReadTextByChar(charDelay));
    }
    public void InvokeDialogueEvent()
    {
        if (curentDialogue.onDialogueStarted != null)
        {
            curentDialogue.onDialogueStarted.Invoke();
        }
    }

    public string GetCurentDialogText()
    {
        if (curentDialogue != null)
        {
            return curentDialogue.textByChar;
        }
        else
        {
            return "";
        }
    }
    public string GetCurentDialogName()
    {
        if (curentDialogue != null)
        {
            return curentDialogue.characterName;
        }
        else
        {
            return "";
        }
    }

    public void NextDialogue()
    {
        if(dialogueIndex + 1 < dialogueList.Count)
        {
            curentDialogue = dialogueList[dialogueIndex + 1];
            dialogueIndex++;
            GenerateTextByChar();
            InvokeDialogueEvent();
        }
    }
    public void PreviousDialogue()
    {
        if (dialogueIndex - 1 >= 0)
        {
            curentDialogue = dialogueList[dialogueIndex - 1];
            dialogueIndex--;
            GenerateTextByChar();
            InvokeDialogueEvent();
        }
    }
    public void LoadDialogueByIndex(int index)
    {
        if(index >= 0 && index < dialogueList.Count)
        {
            curentDialogue = dialogueList[index];
            dialogueIndex = index;
            GenerateTextByChar();
            InvokeDialogueEvent();
        }
    }

}
