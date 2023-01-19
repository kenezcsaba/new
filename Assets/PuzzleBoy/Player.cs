using UnityEngine;

class Player : MonoBehaviour
{
    public float speed = 3.0f;

    Rigidbody2D rb;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * speed);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * speed);
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddForce(Vector3.up * speed);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.AddForce(Vector3.down * speed);

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
