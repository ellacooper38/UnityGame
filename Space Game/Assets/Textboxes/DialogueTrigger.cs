using UnityEngine;
//drag onto object
public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManeger>().StartDialogue(dialogue);
    }
}
