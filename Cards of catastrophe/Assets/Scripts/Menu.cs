using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    private bool Ispaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Ispaused == false)
        {
            Ispaused = true;
            menu.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Ispaused == true)
        {
            Ispaused = false;
            menu.SetActive(false);

        }
    }
}
