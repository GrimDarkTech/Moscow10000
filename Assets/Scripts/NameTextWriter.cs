using UnityEngine;
using UnityEngine.UI;

public class NameTextWriter : MonoBehaviour
{
    private Text text;

    [SerializeField]
    private DialogueManager dialogueManager;

    private void Start()
    {
        text = gameObject.GetComponent<Text>();
        
    }
    private void OnGUI()
    {
        text.text = dialogueManager.GetCurentDialogName();
    }
}
