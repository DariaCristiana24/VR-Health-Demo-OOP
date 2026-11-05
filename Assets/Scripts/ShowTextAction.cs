using TMPro;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Subclass: displays a message in a TextMeshPro text when the object is selected.
/// Attach this script to the grabbable object (e.g. the cube).
/// </summary>
public class ShowTextAction : InteractableAction
{
    // Drag the TextMeshPro text from the scene here.
    [SerializeField] private TMP_Text targetText;

    // Text to display; can be changed per object in the Inspector.
    [SerializeField] private string message = "You grabbed the cube!";

    [SerializeField] UnityEvent onExecute;
    protected override void Execute()
    {
        if (targetText != null)
        {
            targetText.text = message;
        }
        onExecute.Invoke();
    }
}
