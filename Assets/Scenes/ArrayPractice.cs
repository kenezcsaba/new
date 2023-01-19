using System.Collections.Generic;
using UnityEngine;

class ArrayPractice : MonoBehaviour
{
        // array = t�mb

    [SerializeField] int[] intArray;
    [SerializeField] List<int> intList;             // using System.Collections.Generic; ez kell using-olni :DD  generikus list�k ebben vannak benne
    [SerializeField] List<int> intList2;


    void Start()
    {
        for (int i = 0; i < intArray.Length; i++)
        {

            int element = intArray[i];
            Debug.Log(element);

        }

        foreach ( int element in intArray)              // ez ugyanaz mint feljebb ,amin v�gig lehet iter�lni (l�pkedni) ott alkalmazhat� a foreacg, ilyenek a t�mb�k
        {
            Debug.Log(element);
        }


        for (int i = intArray.Length - 1; i >= 0; i--)          // visszafele ki�rva az �rt�kek
        {

            int element = intArray[i];                              //k�db�l nem tudok t�mb elemet t�r�lni csak unityben
            Debug.Log(element);

        }



        int[] intArray2 = new int[10];          // l�trehoztunk egy 10 elem� t�mb�t
        for (int i = 0; i < intArray2.Length; i++)
        {
            int a = i + 1;
            intArray2[i] = a * a;
            Debug.Log(intArray2[i]);
            //intArray[0] = 1;              be�ll�tunk egy �rt�ket a [0]-dik elemnek
            // .ToString() mindenb�l lehet stringet csin�lni �gy
        }

        int[] intArray3 = new int[10];
        
        intArray3[0] = 1;
        intArray3[1] = 1;
        Debug.Log("1");
        Debug.Log("1");


        for (int i = 2; i < intArray3.Length; i++)
        {


            intArray3[i] = intArray3[i-1] + intArray3[i-2];
            Debug.Log(intArray3[i]);

        }


        List<string> stringList = new List<string>();               // kezdetben nulla elem�, nem kell megadni h mekkora a lista   
        for (int i = 0; i < 10; i++)
        {
            int num = (i + 1) * (i + 1);
            stringList.Add(num.ToString());                                     // .ToString() mindenb�l lehet stringet csin�lni �gy
        }


        foreach (string e in stringList)
        {
            Debug.Log(e);
        }

        for (int i = 0; i < stringList.Count; i++)
        {
            string e = stringList[i];
            Debug.Log(e);
        }
            
        bool succesfulRemove = stringList.Remove("50");                 // remove mindig olyan t�pust v�r mint amilyen a lista vagy amir�l sz� van 
        stringList.RemoveAt(3);                                         // a 3. index�t, teh�t a negyedik elemet kiveszi

        //stringList.Clear();               �r�tj�k a list�t

        for (int i = 0; i < stringList.Count; i++)
        {
            stringList.RemoveAt(0);
        }


        //List<int> intList2 = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            int random = Random.Range(1, 101);
            intList2.Add(random);
        }


        // t�r�lj�k a p�ros �rt�k� elemeket
      

        for (int i = intList2.Count - 1; i >= 0; i--)
        {
            int element = intList2[i];

            if (element % 2 == 0)
            {
                intList2.RemoveAt(i);
                //i--;           ez helyes ,megold�s lenne ha el�lr�l megy�nk a list�n azaz i++ a for ciklus
            }
        }


        intList2.Sort();            // sorba teszi a Unityben
        stringList.Insert(5, "Alma");
        bool c = stringList.Contains("K�rte");
        int KorteIndex = stringList.IndexOf("K�rte");               //-1  -et ad vissza             ha t�bb is van, az els�t adja vissza

        List<int> intList5 = new List<int>(intArray);               // param�terben t�mb�t adok meg a list�mnak amit l�trehoztam
        int[] intArray5 = intList5.ToArray();                       // findobject meg ezek a m�veletek t�mb�t adnak, azokkal ha kezdeni akarunk valamit akkor list�v� alak�tjuk
                                                                    // l�ncolt lista is l�tezik a programoz�sban, a C#-ban nem l�ncolt a lista   az valami linked list lenne






    }

}
