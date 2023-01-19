using UnityEngine;

class PracticeNY : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string text;


    void OnValidate()
    {
        text = "";

        for (int i = 1; i <= number; i++)
        {
            text += i;

            if (i != number)
            {
                text += ", ";
            }
        }
    }


}
