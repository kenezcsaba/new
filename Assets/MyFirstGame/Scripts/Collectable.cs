using UnityEngine;

class Collectable : MonoBehaviour
{
    //publikuss� t�tel el�tt:
    //[SerializeField] int value = 1;

    //minden public ParticleSystemForceField az automatikusan SerializeField lesz

    public int value = 1;
    [SerializeField] Bounds teleportBounds;             // teleport�l� helyet hoztunk l�tre 


    public int GetValue()              // csak az �rt�k�t adja meg mindenki hozz� tud f�rni �s le tudja k�rdezni de m�dos�tani nem
    {
        return value;
    }


    void OnDrawGizmos()
    {

        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(teleportBounds.center, teleportBounds.size);        // size az az extend dupl�ja m�rmint t�glatestn�l ami szab�lyos :)

    }

    //teleport met�dus

    public void Teleport()
    {

        // v�letlen pont kiv�laszt�sa a ground-on (j�t�kt�rben)
        //float random = Random.Range(0, 1);              // mi k�z� akarom tenni, ez a k�t param�ter amit meg kell adni - ez az int -es verzi�,  a fels� �rt�k ki van z�rva a tartom�nyb�l l�sd maxExclusive
        //float random = Random.Range(0f, 1f);                // ez a float - os verzi� , itt beletartozik a min �s a max is

        Vector3 min = teleportBounds.min;
        Vector3 max = teleportBounds.max;

        float randomX = Random.Range(min.x, max.x);
        float randomY = Random.Range(min.y, max.y);
        float randomZ = Random.Range(min.z, max.z);

        Vector3 randomPoint = new Vector3(randomX, randomY, randomZ);
        transform.position = randomPoint;

    }


}
