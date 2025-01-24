using UnityEngine;

public class FinalizeSquadButton : MonoBehaviour
{
    public void OnFinalizeSquadButtonClick()
    {
        RecruitmentManager.Instance.CloseRecruitmentPanel();
        // Additional logic for finalizing the squad goes here
    }
}
