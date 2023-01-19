using UnityEngine;

class Questions : MonoBehaviour                                       
{                                   // Tömb feltöltése sorban 
    [SerializeField] int number;
    [SerializeField] int[] array;



    void OnValidate()
    {
        array = new int[number];              // ez így miért nem jó OnValidate-en kívül??? hol máshol jó? Startban jó

        for (int i = 0; i < number; i++)
        {
            array[i] = i + 1;
        }

    }

   

}






/*

---------------------------------------------------------------------------------------------------------------------------------------

using UnityEngine;
                                                    mi az a Mathf.LercUnclamped??? nincsenek határai a lerp-nek?  ill
class Questions : MonoBehaviour                                                           // az egéazet :)))
{
    // Tesztelésre:
    [SerializeField] float a, b;
    [SerializeField] float t;

    [SerializeField] float lerp;
    [SerializeField] float lerpUnclamped;
    
    void OnValidate()
    { 
        lerp = Lerp(a, b, t);
        lerpUnclamped = LerpUnclamped(a, b, t);
    }

    // Lényegi megoldás:
    float LerpUnclamped(float a, float b, float t)
    {
        // LerpUnclamped lineáris függvény:
        // Csak a meredeksége és az eltolása a kérdés.
        
        float dif = b - a;          // A két szám különbsége fogja mutatni,
                                    // hogy egy egység alatt
																		// mennyit változik a függvény értéke.
        float multiplied = t * dif; // Ez lesz a függvény meredeksége
        return a + multiplied;      // Függõlegesen eltoljuk a függvényt a-val.
    }
    
    float Lerp(float a, float b, float t)
    {
        // Ne kezdjük elõlrõl!
        // Felhasználhatjuka a LerpUnclamped függvényünket.
        float l = LerpUnclamped(a, b, t);
        float min = Mathf.Min(a, b);
        float max = Mathf.Max(a, b);
        return Mathf.Clamp(l, min, max);
    }
}

  

-----------------------------------------------------------------------------------------------------------------------------------  
  
 Folyamatos mozgás gombnyomásra  nem kell a Down!!!!!!!!!!!!!!!!! 
------------------------------------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour             // Tömbmatek
{

    [SerializeField] float[] array;
    [SerializeField] float summa;
    [SerializeField] float product;
    [SerializeField] float mean;


    void OnValidate()
    {
        summa = 0;

        for (int i = 0; i < array.Length; i++)                  // a Tiedben ha nulla elemû a tömb akkor is a szorzatuk 1, az hiba?
        {
            summa += array[i];
        }

        //if (array.Length == 0)
        if (array == null)                              // ez miért nem mûködik? productot szeretném 0 elemû tömb esetén 0-ra állítani
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

class First : MonoBehaviour                                         //Tömb feltöltése ha nem osztható 
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


        count = 0;                                      //1 és n közt úgy érted h 1 még benne van de n már nincs? mert akkor 
        for (int i = 1; i <= number; i++)                       // ide valóben nem kell <= de ha n még benne van akkor kell =
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
            if (i % 3 != 0 && i % 7 != 0)                       // és ez a rész a Tiedben nem jó szerintem
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

class Questions : MonoBehaviour                                 //Minimum- és maximumkeresõ függvény tömbön
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
        if (array == null || array.Length == 0)                            // itt mi a különbség? és unityben?
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

class Questions : MonoBehaviour                                         //Tartalom megfordítása 
{
    //  Tartalom megfordítása

    [SerializeField] int[] array = Array.Empty<int>();                  // ez mi a fene? ebbõl megtudom a listámat?
                                                                        // ez azt jelenti h unityben van egy array nevû listám aminek
                                                                        // a tartalmának a méretét tudom változtatni és a tartalmának
                                                                        // az értékeit is?



    void Start()
    {
        ChangeOrder(array);
    }

    void ChangeOrder(int[] helper)              // void típusú függvény az mit jelent? csak void-os metódusban használható? miért nem int[] a típus?
                                                // Starton kívül miben használhatnám? Én is létre tudok hozni void típusú metódusokat?
    {

        if (helper == null)                                     // ez miért kell???                           
            return;                                                 // innen hiányzik helper vagyis array null/0-t nem fogadja el ugye?

        for (int i = 0; i < helper.Length / 2; i++)
        {

            int i2 = helper.Length - 1 - i;

            int temp = helper[i];
            helper[i] = helper[i2];
            helper[i2] = temp;


        }
        return helper;                                                  // Ez nálad lemaradt vagyis return array;

    }

}

--------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour                                             // Ötöslottó
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
                int index = Random.Range(1, 91);                // ezt hogy lehetne megcsinálni?
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
        for (int i = 0; i < ((char)a) ; i++)          //ez hogyan lenne jó??
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
        for (int i = 1; count < number; i++)                             //hol a hiba???  végeredmény: number-szer number számjegyeinek összege
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
    // Tesztelésre:
    [SerializeField] Vector2 a, b;   // Bemeneti változók    
    [SerializeField] int stepCount;  // Kimeneti változó
    
    void OnValidate()
    {
        stepCount = GetStepCount(a, b, 1);
    }
    
    // Lényegi megoldás:
    int GetStepCount(Vector2 a, Vector2 b, float maxStepLength)
    {
        Vector2 dirVec = b - a;             // a-ból b-be mutató vektor.

        // Az a megoldásötlet, hogy két részre osztom a megtehetõ utat.
        // Amíg lehet megyek átlósan,
				// a maradékot a tengelyek mentén teszem meg
        
        float x = dirVec.x;
        float y = dirVec.y; 

        float min = Mathf.Min(x, y);    // Rövidebbik oldal
        float max = Mathf.Max(x, y);    // Hosszabbik oldal

        float diagonal = min * Mathf.Sqrt(2);  // Átlósan megtehatõ út
        float straight = max - min;            // Tengelyekre merõleges út                                  //ez itt nem jó

        int stepCountDiagonal = (int)(diagonal / maxStepLength);
        int stepCountStraight = (int)(straight / maxStepLength);
        return stepCountDiagonal + stepCountStraight;                                                     // ide pedig nem árt egy Mathf.Abs  
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
        transform.position = Vector3.MoveTowards(current, target, distance * Time.deltaTime);               // ez jó??
    }

    //   transform.Translate(inputVector * Time.deltaTime);                          //   e helyett
                                                                                        // mi az a transform.Translate???
}
----------------------------------------------------------------------------------------------------------------------

using UnityEngine;

class Questions : MonoBehaviour                 //Átlépés a négyzetrácson
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


using UnityEngine;                                                       //az egészet!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                                                                        //inkább ezt :)

public class Questions : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float angularSpeed = 360;

    float currentAngle;
    float radius;

    void Start()
    {
        // Kezdetben kiszámítom a szöget és a kezdõ fokot
        Vector2 v = transform.position - center;
        currentAngle = Vector2.Angle(v, Vector2.right);
        radius = v.magnitude;
    } 

    void Update()
    {
        // Növelem a jelenlegi szöget a szögsebességnek megfeleõen.
        currentAngle += angularSpeed * Time.deltaTime;
        
        // Szinusz és Coszinusz függvényekbõl állítom elõ a pozíciót 
        float angleInRadians = currentAngle * Mathf.Deg2Rad;
        float x = Mathf.Cos(angleInRadians);
        float y = Mathf.Sin(angleInRadians);
        Vector3 pos = new Vector3(x, y, 0);
        
        pos *= radius;      // Átméretezem a kört sugár szereint
        pos += center;      // Eltolom a pozíciót a középponttól
        
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

using UnityEngine;                      //Automata forgató                                  //az egészet!!!!!!!!!!!!!!!!!!!!!!!!!!!

public class Questions : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float angularSpeed = 360;

    float currentAngle;
    float radius;

    void Start()
    {
        // Kezdetben kiszámítom a szöget és a kezdõ fokot
        Vector2 v = transform.position - center;
        currentAngle = Vector2.Angle(v, Vector2.right);
        radius = v.magnitude;
    } 

    void Update()
    {
        // Növelem a jelenlegi szöget a szögsebességnek megfeleõen.
        currentAngle += angularSpeed * Time.deltaTime;
        
        // Szinusz és Coszinusz függvényekbõl állítom elõ a pozíciót 
        float angleInRadians = currentAngle * Mathf.Deg2Rad;
        float x = Mathf.Cos(angleInRadians);
        float y = Mathf.Sin(angleInRadians);
        Vector3 pos = new Vector3(x, y, 0);
        
        pos *= radius;      // Átméretezem a kört sugár szereint
        pos += center;      // Eltolom a pozíciót a középponttól
        
        transform.position = pos;
    }
}

*/



