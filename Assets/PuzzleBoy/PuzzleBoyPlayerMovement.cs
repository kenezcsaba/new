using UnityEngine;

public class PuzzleBoyPlayerMovement : MonoBehaviour
{

    [SerializeField] float speed = 5; 

    Vector3 target;

    void Start()
    {
        target = transform.position;

    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow))
        { target += Vector3.up; }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        { target += Vector3.down; }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { target += Vector3.left; }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        { target += Vector3.right; }

        Vector3 selfPos = transform.position;

        transform.position = Vector3.MoveTowards(selfPos, target, speed * Time.deltaTime);

    }
}
