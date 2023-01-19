using UnityEngine;

class Collector : MonoBehaviour
{
    int collectedValue = 0;              // egy v�ltoz� �rt�k hogy mennyit gy�jttt�nk eddig

    // collider kell ahhoz hogy k�t objectum, �sze tudjon �rni

    // triggerre �ll�tjuk a collidereket (ill el�g csak az egyiket) �tk�z�s nem lesz csak kapunk egy �zenetet h �ssze�rtek, legal�b az egyik objektumon kell lennie rigidbodynak �s Is Kinematic -ot be kell pip�lni

    void OnTriggerEnter(Collider other)             // unity �letciklus met�dus akkor h�vja meg a unity amikor bel�p�nk egy triggerbe amikoir 2 trigger tal�lkozik
    {
        // meg kell n�zn�nk hogy van e a m�sik t�rgyon collectable komponense

        // Collectable collectable = other.gameObject.GetComponent<Collectable>(); ennek az egyszer�bb v�ltozata:
        Collectable collectable = other.GetComponent<Collectable>();        // ha nincs collectable komponense akkor NULL �rt�ket ad 

        if (collectable != null )
        {

            collectedValue += collectable.GetValue();       // n�velj�k az eddig �sszegy�jt�tt pontokat

            Debug.Log("Collected: " + collectedValue);      // majd ki�rjuk
            collectable.Teleport();
        }


    }

}
