using UnityEngine;


class PhysicsOne : MonoBehaviour
{
    [SerializeField] float force = 10f;
    [SerializeField] float range = 5f;

    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;


        Camera mainCam = Camera.main;
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit))
            return;


        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody rb in rigidbodies)
        {

            float distance = Vector3.Distance(rb.transform.position, hit.point);
            float rate = 1 - (distance / range);
            
            if (rate > 0)
                rb.AddForce(Vector3.up * (rate * force), ForceMode.Impulse);
        }
        



    }
}
