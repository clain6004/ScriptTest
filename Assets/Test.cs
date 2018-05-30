using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {

    public int mp = 53;

    public void Magic(int mps)
    {
       
        if (mp >= 3)
        {

            mp -= mps;

            Debug.Log("魔法を使用した。残りMPは" + mp);

        }
        else
        {

            Debug.Log("MPが足りないため魔法が使えない");

        }



    }
}


public class Test : MonoBehaviour {
 
	// Use this for initialization
	void Start () {

        Debug.Log("発展課題です");

        Boss lastboss = new Boss();
       
        

        for(int i = 1; i <= 11; i++)
        {

            lastboss.Magic(5);

        

        }

        int[] array = { 6, 7, 64, 67,70 };

 Debug.Log("配列の宣言です");

        for (int i = 0; i < array.Length; i++)
        {

            Debug.Log(array[i]);

        }
        Debug.Log("配列の逆の宣言です");

        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);

        }
    }	
	// Update is called once per frame
	void Update () {
		
	}
   
}
