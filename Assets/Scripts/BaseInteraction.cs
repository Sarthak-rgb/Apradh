using UnityEngine;

public class BaseInteraction : MonoBehaviour
{
    public GameObject contextMenuPrefab;

    private void OnMouseDown()
    {
        // Close the recruitment panel if it's open
        RecruitmentManager.Instance.CloseRecruitmentPanel();

        // Open the context menu
        ContextMenuManager.Instance.OpenContextMenu(transform.position, this.gameObject);
    }
}
