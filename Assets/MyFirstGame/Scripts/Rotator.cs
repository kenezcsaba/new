using UnityEngine;

class Rotator : MonoBehaviour
{

    [SerializeField] float angularSpeed;
    [SerializeField] Space rotationSpace;
    [SerializeField] Vector3 axis = Vector3.up;

    void Update()
    {

        float angle = angularSpeed * Time.deltaTime;

        transform.Rotate(axis, angle, rotationSpace);                    //k�l.� param�terei lehetnek verloadok? Space - world/self a forg�s ir�ny�t az alap�rtelmezetthez k�pest �ll�tottuk
                                                                         //az itteni param�tereket betett�k [SerializeField] �ll�that� param�ternek

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 center = transform.position;

        Vector3 dir = axis.normalized;

        if (rotationSpace == Space.Self)
        {
            dir = transform.TransformDirection(dir);

            //Vector3 localUp = transform.up;
            //Vector3 localUp2 = transform.TransformDirection(Vector3.up);          csak tudjuk hogy van ilyen 

            //transform.InverseTransformPoint(transform.up);
            
        }


        Vector3 a = center + dir;       // axis a tengely ami k�r�l forgatjuk
        Vector3 b = center - dir;
        Gizmos.DrawLine(a,b);
    }


}
