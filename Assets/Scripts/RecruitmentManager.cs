using UnityEngine;

public class RecruitmentManager : MonoBehaviour
{
    public static RecruitmentManager Instance;

    public GameObject recruitmentPanelPrefab;
    private GameObject currentRecruitmentPanel;
    private GameObject selectedBase;

    private void Awake()
    {
        Instance = this;
    }

    public void SetSelectedBase(GameObject baseObject)
    {
        selectedBase = baseObject;
    }

    public void OpenRecruitmentPanel()
    {
        // Close the context menu if open
        ContextMenuManager.Instance.CloseContextMenu();

        // Destroy the existing recruitment panel if it exists
        if (currentRecruitmentPanel != null)
        {
            Destroy(currentRecruitmentPanel);
        }

        // Instantiate the new recruitment panel
        currentRecruitmentPanel = Instantiate(recruitmentPanelPrefab, GameObject.Find("global_canvas").transform);
        
        // Set the position and make the recruitment panel active
        RectTransform rectTransform = currentRecruitmentPanel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = Vector2.zero;

        // Set the recruitment panel as active
        currentRecruitmentPanel.SetActive(true); // Ensure it is active
    }

    public void CloseRecruitmentPanel()
    {
        if (currentRecruitmentPanel != null)
        {
            Destroy(currentRecruitmentPanel);
            currentRecruitmentPanel = null;
        }
    }
}
