using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] Transform center;
    [SerializeField] float maxDistance = 5;

    void Update()
    {
        Vector3 centerPosition = center.position;
        Vector3 direction = transform.position - centerPosition;

        if (direction.magnitude > maxDistance) // Ha tullóg a határon
        {
            // Visszateszem a határra
            transform.position = centerPosition + direction.normalized * maxDistance;
        }
    }
    /*
    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(center.position, maxDistance);
    }*/
}