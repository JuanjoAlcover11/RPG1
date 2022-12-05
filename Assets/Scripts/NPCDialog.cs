using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class NPCDialog : MonoBehaviour
{
    public string npcName;
    public string npcDialog;
    private DialogManager dialogManager;
    private bool isPlayerInDialogZone;

    private void Start()
    {
        dialogManager = FindObjectOfType<DialogManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            isPlayerInDialogZone = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            isPlayerInDialogZone = false;
        }
    }
    private string DialogPlusNPCName()
    {
        string finalDialog;

        if (npcName != null)
        {
            finalDialog = $"{npcName}\n{npcDialog}";
        }
        else
        {
            finalDialog = npcDialog;
        }
           
        return finalDialog;
        
    }
    private void Update()
    {
        if (isPlayerInDialogZone && Input.GetMouseButtonDown(1))
        {
            dialogManager.ShowDialog(DialogPlusNPCName());
        }
    }
}


