using UnityEngine;

class DamageBox : MonoBehaviour
{

    [SerializeField] int damage = 10;
    [SerializeField] bool instantKill = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthObject healthObject = collision.gameObject.GetComponent<HealthObject>();              //t�pust adtunk be param�ternek             ez egy lok�slis v�ltoz�
        if (healthObject != null)
        {
            if (instantKill)
            {
                healthObject.Kill();
            }
            else
            {
                healthObject.Damage(damage);                // ez egy met�dus amit meg kell csin�lnunk
            }

        }

        // Debug.Log("DEATH!!");
        // Destroy(collision.gameObject);
    }                                                                                               //    ID�IG L�TEZIK A LOK�LIS V�LTOZ�




}
