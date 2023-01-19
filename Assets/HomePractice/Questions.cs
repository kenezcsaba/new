using UnityEngine;

class Questions : MonoBehaviour                                       
{                                   // T�mb felt�lt�se sorban 
    [SerializeField] int number;
    [SerializeField] int[] array;



    void OnValidate()
    {
        array = new int[number];              // ez �gy mi�rt nem j� OnValidate-en k�v�l??? hol m�shol j�? Startban j�

        for (int i = 0; i < number; i++)
        {
            array[i] = i + 1;
        }

    }

   

}






/*

---------------------------------------------------------------------------------------------------------------------------------------

using UnityEngine;
                                                    mi az a Mathf.LercUnclamped??? nincsenek hat�rai a lerp-nek?  ill
class Questions : MonoBehaviour                                                           // az eg�azet :)))
{
    // Tesztel�sre:
    [SerializeField] float a, b;
    [SerializeField] float t;

    [SerializeField] float lerp;
    [SerializeField] float lerpUnclamped;
    
    void OnValidate()
    { 
        lerp = Lerp(a, b, t);
        lerpUnclamped = LerpUnclamped(a, b, t);
    }

    // L�nyegi megold�s:
    float LerpUnclamped(float a, float b, float t)
    {
        // LerpUnclamped line�ris f�ggv�ny:
        // Csak a meredeks�ge �s az eltol�sa a k�rd�s.
        
        float dif = b - a;          // A k�t sz�m k�l�nbs�ge fogja mutatni,
                                    // hogy egy egys�g alatt
																		// mennyit v�ltozik a f�ggv�ny �rt�ke.
        float multiplied = t * dif; // Ez lesz a f�ggv�ny meredeks�ge
        return a + multiplied;      // F�gg�legesen eltoljuk a f�ggv�nyt a-val.
    }
    
    float Lerp(float a, float b, float t)
    {
        // Ne kezdj�k el�lr�l!
        // Felhaszn�lhatjuka a LerpUnclamped f�ggv�ny�nket.
        float l = LerpUnclamped(a, b, t);
        float min = Mathf.Min(a, b);
        float max = Mathf.Max(a, b);
        return Mathf.Clamp(l, min, max);
    }
}

  

-----------------------------------------------------------------------------------------------------------------------------------  
  
 Folyamatos mozg�s gombnyom�sra  nem kell a Down!!!!!!!!!!!!!!!!! 
------------------------------------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour             // T�mbmatek
{

    [SerializeField] float[] array;
    [SerializeField] float summa;
    [SerializeField] float product;
    [SerializeField] float mean;


    void OnValidate()
    {
        summa = 0;

        for (int i = 0; i < array.Length; i++)                  // a Tiedben ha nulla elem� a t�mb akkor is a szorzatuk 1, az hiba?
        {
            summa += array[i];
        }

        //if (array.Length == 0)
        if (array == null)                              // ez mi�rt nem m�k�dik? productot szeretn�m 0 elem� t�mb eset�n 0-ra �ll�tani
        {
            product = 0;
        }
        else
        {
            product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
        }
        mean = summa / array.Length;                        


    }




}


/*
-------------------------------------------------------------------------------------------------------------------------------------------
using UnityEngine;

class First : MonoBehaviour                                         //T�mb felt�lt�se ha nem oszthat� 
{
    [SerializeField] int number;
    [SerializeField] int[] arrayA, arrayB;

    void OnValidate()
    {
        arrayA = new int[number];

        int count = 0;
        for (int i = 0; count < number; i++)
        {
            if (i % 4 != 0 && i % 5 != 0)
            {
                arrayA[count] = i;
                count++;
            }

        }


        count = 0;                                      //1 �s n k�zt �gy �rted h 1 m�g benne van de n m�r nincs? mert akkor 
        for (int i = 1; i <= number; i++)                       // ide val�ben nem kell <= de ha n m�g benne van akkor kell =
        {
            if (i % 3 != 0 && i % 7 != 0)                           // ez
            {
                count++;                                        
            }
        }

        arrayB = new int[count];
        count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)                       // �s ez a r�sz a Tiedben nem j� szerintem
            {
                arrayB[count] = i;
                count++;
               
            }
        }





    }
}

---------------------------------------------------------------------------------------------------------------------------------------------
using System;
using UnityEngine;

class Questions : MonoBehaviour                                 //Minimum- �s maximumkeres� f�ggv�ny t�mb�n
{

    [SerializeField] float[] array = Array.Empty<float>();
    [Space]                                                        
    [SerializeField] float max;
    [SerializeField] float min;


    void OnValidate()
    {
        max = Max(array);
        min = Min(array);
    }

    float Max(float[] array)
    {
        if (array == null || array.Length == 0)                            // itt mi a k�l�nbs�g? �s unityben?
            return 0;

        float max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }


    float Min(float[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        float min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }
}



----------------------------------------------------------------------------------------------------------------------------------------------

using System;
using UnityEngine;

class Questions : MonoBehaviour                                         //Tartalom megford�t�sa 
{
    //  Tartalom megford�t�sa

    [SerializeField] int[] array = Array.Empty<int>();                  // ez mi a fene? ebb�l megtudom a list�mat?
                                                                        // ez azt jelenti h unityben van egy array nev� list�m aminek
                                                                        // a tartalm�nak a m�ret�t tudom v�ltoztatni �s a tartalm�nak
                                                                        // az �rt�keit is?



    void Start()
    {
        ChangeOrder(array);
    }

    void ChangeOrder(int[] helper)              // void t�pus� f�ggv�ny az mit jelent? csak void-os met�dusban haszn�lhat�? mi�rt nem int[] a t�pus?
                                                // Starton k�v�l miben haszn�lhatn�m? �n is l�tre tudok hozni void t�pus� met�dusokat?
    {

        if (helper == null)                                     // ez mi�rt kell???                           
            return;                                                 // innen hi�nyzik helper vagyis array null/0-t nem fogadja el ugye?

        for (int i = 0; i < helper.Length / 2; i++)
        {

            int i2 = helper.Length - 1 - i;

            int temp = helper[i];
            helper[i] = helper[i2];
            helper[i2] = temp;


        }
        return helper;                                                  // Ez n�lad lemaradt vagyis return array;

    }

}

--------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour                                             // �t�slott�
{
    [SerializeField] int[] array = new int[5];


    void Start()
    {
        array = Generate(array);   
    }

    int[] Generate(int[] array)
    {
        int[] result = new int[5];

        int first = Random.Range(1, 91);
        result[0] = first;
        int count = 1;
        while (result[4] == 0)
        {
            
            for (int j = 0; j < 5; j++)
            {
                int index = Random.Range(1, 91);                // ezt hogy lehetne megcsin�lni?
                if (result[j] != index)
                {
                    result[count] = index;
                    count++;
                }
            }
        }
        return result;
    }

}



-------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int charSumma;


    void OnValidate()
    {
        charSumma = CharSumma(number);   
    }

    int CharSumma(int a)
    {
        int summa = 0;
        // while(a != 0)
        for (int i = 0; i < ((char)a) ; i++)          //ez hogyan lenne j�??
        {
            int lastChar = a % 10;
            summa += lastChar;
            a /= 10; 
        }
        return summa;
    }

}


---------------------------------------------------------------------------------------------------------------------------------------

using UnityEngine;

class First : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string result;

    void OnValidate()
    {
        result = Equal(number);   
    }


    int SummaChar(int number)
    {
        int summa = 0;
        while (number != 0)
        {
            int lastChar = number % 10;
            summa += lastChar;
            number /= 10;
        }
        return summa;
    }

    string Equal(int number)
    {
        int charSumma = SummaChar(number);
        int count = 0;
        string equalNumbers = string.Empty;
        for (int i = 1; count < number; i++)                             //hol a hiba???  v�geredm�ny: number-szer number sz�mjegyeinek �sszege
        {
            int numberToTest = i;

            if (charSumma == numberToTest)
            {
                equalNumbers += numberToTest.ToString();
                count++;
            }
        }
        return equalNumbers;
    }

}

---------------------------------------------------------------------------------------------------------------
using UnityEngine;
    
class Questions : MonoBehaviour
{
    // Tesztel�sre:
    [SerializeField] Vector2 a, b;   // Bemeneti v�ltoz�k    
    [SerializeField] int stepCount;  // Kimeneti v�ltoz�
    
    void OnValidate()
    {
        stepCount = GetStepCount(a, b, 1);
    }
    
    // L�nyegi megold�s:
    int GetStepCount(Vector2 a, Vector2 b, float maxStepLength)
    {
        Vector2 dirVec = b - a;             // a-b�l b-be mutat� vektor.

        // Az a megold�s�tlet, hogy k�t r�szre osztom a megtehet� utat.
        // Am�g lehet megyek �tl�san,
				// a marad�kot a tengelyek ment�n teszem meg
        
        float x = dirVec.x;
        float y = dirVec.y; 

        float min = Mathf.Min(x, y);    // R�videbbik oldal
        float max = Mathf.Max(x, y);    // Hosszabbik oldal

        float diagonal = min * Mathf.Sqrt(2);  // �tl�san megtehat� �t
        float straight = max - min;            // Tengelyekre mer�leges �t                                  //ez itt nem j�

        int stepCountDiagonal = (int)(diagonal / maxStepLength);
        int stepCountStraight = (int)(straight / maxStepLength);
        return stepCountDiagonal + stepCountStraight;                                                     // ide pedig nem �rt egy Mathf.Abs  
    }
}

-------------------------------------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Third : MonoBehaviour
{
    [SerializeField] Vector3 a;

    void Update()
    {
        Vector3 current = transform.position;
        Vector3 target = transform.position + a;
        float distance = a.magnitude;
        transform.position = Vector3.MoveTowards(current, target, distance * Time.deltaTime);               // ez j�??
    }

    //   transform.Translate(inputVector * Time.deltaTime);                          //   e helyett
                                                                                        // mi az a transform.Translate???
}
----------------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour                 //�tl�p�s a n�gyzetr�cson
{
    [SerializeField] float gridSize =10;


    Vector3 lastPos;

    void Start()
    {
        lastPos = transform.position;    
    }

    void Update()
    {
        Vector3 currentPos = transform.position;

        TestAxis(currentPos.x, lastPos.x, "X");
        TestAxis(currentPos.y, lastPos.y, "Y");
        TestAxis(currentPos.z, lastPos.z, "Z");


        lastPos = currentPos;
    }

    void TestAxis(float currentPos, float lastPos, string axis)
    {
        int current = Mathf.FloorToInt( currentPos / gridSize);                 // ez miez pontosan?
        int last = Mathf.FloorToInt(lastPos/ gridSize);

        if (current > last)
        {
            Debug.Log($"{axis} now is higher than {current * gridSize}");
        }
        else if (current < last)
        {
            Debug.Log($"{axis} now is lower than {last * gridSize}");
        }

    
    }


}

------------------------------------------------------------------------------------------------------------


using UnityEngine;                                                       //az eg�szet!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                                                                        //ink�bb ezt :)

public class Questions : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float angularSpeed = 360;

    float currentAngle;
    float radius;

    void Start()
    {
        // Kezdetben kisz�m�tom a sz�get �s a kezd� fokot
        Vector2 v = transform.position - center;
        currentAngle = Vector2.Angle(v, Vector2.right);
        radius = v.magnitude;
    } 

    void Update()
    {
        // N�velem a jelenlegi sz�get a sz�gsebess�gnek megfele�en.
        currentAngle += angularSpeed * Time.deltaTime;
        
        // Szinusz �s Coszinusz f�ggv�nyekb�l �ll�tom el� a poz�ci�t 
        float angleInRadians = currentAngle * Mathf.Deg2Rad;
        float x = Mathf.Cos(angleInRadians);
        float y = Mathf.Sin(angleInRadians);
        Vector3 pos = new Vector3(x, y, 0);
        
        pos *= radius;      // �tm�retezem a k�rt sug�r szereint
        pos += center;      // Eltolom a poz�ci�t a k�z�ppontt�l
        
        transform.position = pos;
    }
}
---------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour
{
    [SerializeField] Transform center;
    [SerializeField] float maxDistance = 10;


    void Update()
    {
        Vector3 centerPos = center.position;
        Vector3 selfPos = transform.position;
        Vector3 direction = selfPos - centerPos;
        float currDistance = direction.magnitude;

        if (currDistance > maxDistance)
        {
            transform.position = centerPos + direction.normalized * maxDistance; 
        }

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(center.position, maxDistance);            //hogyhogy nem fogadja el a centerPos-t?
        
    }

}

--------------------------------------------------------------------------------------------------------------

using UnityEngine;                      //Automata forgat�                                  //az eg�szet!!!!!!!!!!!!!!!!!!!!!!!!!!!

public class Questions : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float angularSpeed = 360;

    float currentAngle;
    float radius;

    void Start()
    {
        // Kezdetben kisz�m�tom a sz�get �s a kezd� fokot
        Vector2 v = transform.position - center;
        currentAngle = Vector2.Angle(v, Vector2.right);
        radius = v.magnitude;
    } 

    void Update()
    {
        // N�velem a jelenlegi sz�get a sz�gsebess�gnek megfele�en.
        currentAngle += angularSpeed * Time.deltaTime;
        
        // Szinusz �s Coszinusz f�ggv�nyekb�l �ll�tom el� a poz�ci�t 
        float angleInRadians = currentAngle * Mathf.Deg2Rad;
        float x = Mathf.Cos(angleInRadians);
        float y = Mathf.Sin(angleInRadians);
        Vector3 pos = new Vector3(x, y, 0);
        
        pos *= radius;      // �tm�retezem a k�rt sug�r szereint
        pos += center;      // Eltolom a poz�ci�t a k�z�ppontt�l
        
        transform.position = pos;
    }
}

*/



