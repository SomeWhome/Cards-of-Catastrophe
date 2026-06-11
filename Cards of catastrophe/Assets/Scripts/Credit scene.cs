using UnityEngine;

public class Creditscene : MonoBehaviour
{
    public GameObject Credits;
    public GameObject startButton;
    public GameObject creditsButton;
    public GameObject CloseButton;

    public void CreditScene()
    {
       Credits.SetActive(true);
        startButton.SetActive(false);
        creditsButton.SetActive(false);
        CloseButton.SetActive(true);
    }
public void CreditSceneClose()
    {
        Credits.SetActive(false);
        startButton.SetActive(true);
        creditsButton.SetActive(true);
        CloseButton.SetActive(false);
    }
}
