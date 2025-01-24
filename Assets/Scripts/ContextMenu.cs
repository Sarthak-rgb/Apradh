using UnityEngine;

public class ContextMenu : MonoBehaviour
{
    public void OnCreateSquadButtonClick()
    {
        RecruitmentManager.Instance.OpenRecruitmentPanel();
        Destroy(gameObject); // Destroy the context menu panel
    }

    public void OnCancelButtonClick()
    {
        Destroy(gameObject); // Destroy the context menu panel
    }
}
