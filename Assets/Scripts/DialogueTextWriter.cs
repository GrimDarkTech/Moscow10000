using UnityEngine;
using UnityEngine.UI;

public class DialogueTextWriter : MonoBehaviour
{
    private Text text;

    [SerializeField]
    private DialogueManager dialogueManager;

    private void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    private void Update()
    {
        text.text = dialogueManager.GetCurentDialogText();
    }


}
