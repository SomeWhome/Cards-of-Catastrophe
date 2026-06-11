using UnityEngine;

public class CardSnapping : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Grabbable"))
        {
            gameObject.SetActive(true);
        }
    }
}
