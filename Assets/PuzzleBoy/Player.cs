using UnityEngine;

class Player : MonoBehaviour
{
    Rigidbody rb;

    Vector3 velocity;
    void Update()
    {
        rb = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.position += Vector3.right;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.position += Vector3.left;

        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.position += Vector3.up;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.position += Vector3.down;

    }
}
