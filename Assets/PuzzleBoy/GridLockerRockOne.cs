using UnityEngine;

class GridLockerRockOne : MonoBehaviour
{
    void Update()
    {
        // Saj�t poz�ci�
        Vector3 pos = transform.position;
        {
            // Kerek�tett poz�ci�
            Vector3 rounded = new Vector3(
                RoundHalfX(pos.x),
                RoundHalf(pos.y),
                Mathf.Round(-1));


            // Vissza�rjuk a kerek�tett poz�ci�t
            transform.position = rounded;
        }
    }

    float RoundHalf(float a)
    {
        float remainder = Mathf.Abs(a) % 1;
        return a > 0 ? a - remainder + 0.5f : a + remainder - 0.5f;


    }
    float RoundHalfX(float a)
    {
        float remainder = Mathf.Abs(a) % 1;
        return a > 0 ? a - remainder : a + remainder;


    }


}