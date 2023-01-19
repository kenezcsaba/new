using UnityEngine;

class AgainOne : MonoBehaviour
{
    [SerializeField] Vector3 a, b;
    [SerializeField] Color colorA, colorB;
    [SerializeField,Range(0,1)] float f;
    [SerializeField] float whireRadius;


    void OnValidate()
    {
        transform.position = Vector3.Lerp(a, b, f);    
    }

    void OnDrawGizmos()
    {
        Gizmos.color = colorA;
        Gizmos.DrawWireSphere(a,whireRadius);
        Gizmos.color = colorB;
        Gizmos.DrawWireSphere(b, whireRadius);


        Gizmos.color = Color.Lerp(colorA,colorB,f);
        Gizmos.DrawLine(a,b);
    }


}
