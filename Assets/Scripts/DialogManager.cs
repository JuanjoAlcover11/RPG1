using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogManager : MonoBehaviour
{
    public GameObject dialogPanel;
    public TextMeshProUGUI dialogTextBox;
    public bool isDialogActive;

    private void Start()
    {
        HideDialog();
    }
    private void Update()
    {
        if (isDialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            HideDialog();
        }
    }
    public void ShowDialog(string message)
    {
        isDialogActive = true;
        dialogPanel.SetActive(isDialogActive);
        dialogTextBox.text = message;
    }
    public void HideDialog()
    {
        isDialogActive = false;
        dialogPanel.SetActive(isDialogActive);
    }
}
