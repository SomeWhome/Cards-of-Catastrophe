using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Texture2D CursorTexture;
    public Vector2 hotspot = Vector2.zero;
    public CursorMode cursormode = CursorMode.Auto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.SetCursor(CursorTexture, hotspot, cursormode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
