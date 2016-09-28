using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float smoothing = 2.0f;
    public float sensitivity = 5.0f;
    GameObject character;
    // Use this for initialization
    void Start()
    {
        character = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorV = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        cursorV = Vector2.Scale(cursorV, new Vector2(smoothing * sensitivity, smoothing * sensitivity));
        smoothV.x = Mathf.Lerp(smoothV.x, cursorV.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, cursorV.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
