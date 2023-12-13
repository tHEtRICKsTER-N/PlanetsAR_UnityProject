using UnityEngine;

public class Selection : MonoBehaviour
{
    Outline outline;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }

    public void ToggleOutlineVisualizer()
    {
        if (outline.enabled)
        {
            outline.enabled = false;
        }
        else
        {
            outline.enabled = true;
        }
    }
}
