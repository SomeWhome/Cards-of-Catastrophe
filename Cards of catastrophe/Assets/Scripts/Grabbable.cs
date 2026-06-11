using UnityEngine;

public class Grabbable : MonoBehaviour
{
    public GameObject Curser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grabbable") && Input.GetMouseButton(0))
        {
            collision.gameObject.transform.SetParent(Curser.transform, true);
        } 
           
    }
}
