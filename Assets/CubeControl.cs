using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();
        rotateCube();
        UpAndDown();
        crouch();
    }
    void MoveCube()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * 5);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * 5);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * 5);
    }

    void rotateCube()
    {
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up, -90 * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up, 90 * Time.deltaTime);
    }

    void UpAndDown()
    {
        //Jump movement for the cube
        if (Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * Time.deltaTime * 5);
    }
    void crouch()
    {
        // Crouch movement for the cube when pressed left crtl go down and when released go up
        // the scale of the cube is by the x,y,z is 1,3,1 the cube should go to 1,1.5,1 when crouching and go back up when released
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1, 1.5f, 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1, 3, 1);
        }
    }
}
