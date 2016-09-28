using UnityEngine;
using System.Collections;

public class CustomCharacterController : MonoBehaviour
{
    public float speed = 10.5f;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Forward and backward movement (the character is moving along Z axis in the environment)
        float z = Input.GetAxis("Vertical") * speed;
        // Left and right movement (the character is standing in same place but moving left and right)
        float x = Input.GetAxis("Horizontal") * speed;
        // Smoothen the transition
        z *= Time.deltaTime;
        x *= Time.deltaTime;
        // Apply the transformation
        transform.Translate(x, 0, z);

        // Change the cursor state while coming out of the play
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

       /* if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("O key detected");
            menuPanel.SetActive(true);
            menuPanel.transform.localRotation = Quaternion.AngleAxis(0, Vector3.right);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            menuPanel.transform.localRotation = Quaternion.AngleAxis(90, Vector3.right);
            helpPanel.SetActive(false);
        }*/
    }
}
