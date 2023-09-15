using System.Collections;
using UnityEngine;
using TMPro;
public class NPCTrigger : MonoBehaviour
{
    public GameObject CopyNPCDialogue, player;
    public int currentLineIndex = 0, branchingIndex = 1000;
    public bool flag { get; set; } = false;
    public TextMeshProUGUI dialogueText;
    public string[] DialogueOption1, DialogueOption2;
    private string[] lines;
    public float textSpeed;
    public bool isSoldier = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        player = collider.gameObject;
        player.GetComponent<PlayerController>().canMove = false;

        CopyNPCDialogue.gameObject.SetActive(true);


        dialogueText.text = string.Empty;

        if (flag)
            lines = DialogueOption2;
        else
            lines = DialogueOption1;

        DialogueBegin();
    }

    public void GoNext()
    {
        Debug.Log(currentLineIndex);
        if (dialogueText.text == lines[currentLineIndex])
            NextLine();
        else
        {
            StopAllCoroutines();
            dialogueText.text = lines[currentLineIndex];
        }
    }

    void DialogueBegin()
    {
        currentLineIndex = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[currentLineIndex].ToCharArray())
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
            GoNext();
        }
        else
        {
            if (isSoldier && flag)
                ObjectiveManagerLvl2.instance.RemoveColliders();

            player.GetComponent<PlayerController>().canMove = true;
            currentLineIndex = 0;

            CopyNPCDialogue.gameObject.SetActive(false);
        }
    }
}
