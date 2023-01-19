using UnityEngine;


class AgainTwo : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;
    [SerializeField] float currentHealth = 50f;
    [SerializeField] float width = 3f;
    [SerializeField] float healthDistance = 3f;

    void OnValidate()
    {
        Vector3 pos = transform.position;

        Vector3 healthLine = pos + healthDistance * Vector3.up;
        Vector3 b = healthLine + (width / 2 * Vector3.right);
        Vector3 a = healthLine + (width / 2 * Vector3.left);

        currentHealth = Mathf.Clamp(currentHealth,0,maxHealth);
        float healthratio = currentHealth / maxHealth;
        healthratio = Mathf.Clamp01(healthratio);
        Vector3 seperate = a + width * Vector3.right * healthratio;


        Gizmos.color = Color.green;
        Gizmos.DrawLine(a, seperate);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(seperate, b);
    }

}

