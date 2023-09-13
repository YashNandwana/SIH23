using System.Collections;
using UnityEngine;
using TMPro;
public class NPCDialogueTrigger : MonoBehaviour
{
    public GameObject CopyNPCDialogue;
    public GameObject DialogueBox;
    public int currentLineIndex = 0;
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed;

    private void OnTriggerEnter2D(Collider2D collider)
    { 
        if (collider.CompareTag("Player"))
        {
            CopyNPCDialogue.transform.GetChild(0).gameObject.SetActive(true);
            dialogueText.text = string.Empty;
            DialogueBegin();
        }
    }


    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueText.text == lines[currentLineIndex])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[currentLineIndex];
            }
        }
    }

    void DialogueBegin()
    {
        currentLineIndex = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[currentLineIndex].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        } 
    }

    void NextLine()
    {
        if (currentLineIndex < lines.Length - 1)
        {
            currentLineIndex++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            currentLineIndex = 0;
            gameObject.SetActive(false);
        }
    }
}
