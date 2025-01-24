using UnityEngine;

public class ContextMenuManager : MonoBehaviour
{
    public static ContextMenuManager Instance;

    public GameObject contextMenuPrefab;
    private GameObject currentContextMenu;

    private void Awake()
    {
        Instance = this;
    }

    public void OpenContextMenu(Vector3 basePosition, GameObject selectedBase)
    {
        // Destroy the existing context menu if it exists
        if (currentContextMenu != null)
        {
            Destroy(currentContextMenu);
        }

        // Instantiate the new context menu
        currentContextMenu = Instantiate(contextMenuPrefab, GameObject.Find("global_canvas").transform);

        // Set the position and make the context menu active
        RectTransform rectTransform = currentContextMenu.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = Vector2.zero;

        // Set the context menu as active
        currentContextMenu.SetActive(true); // Ensure it is active

        // Set the selected base in the recruitment manager
        RecruitmentManager.Instance.SetSelectedBase(selectedBase);
    }

    public void CloseContextMenu()
    {
        if (currentContextMenu != null)
        {
            Destroy(currentContextMenu);
            currentContextMenu = null;
        }
    }
}
