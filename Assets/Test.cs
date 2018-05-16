using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    int mp = 53;
    public void Magic()
    {
        for(int a=1;a<=11;a++ )
        if (mp > 3)
        {

            mp -= 5;

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
       
        lastboss.Magic();

        int[] array = { 6, 7, 64, 67 };
 Debug.Log("配列の宣言です");
        for (int i = 0; i < array.Length; i++)
        {

            Debug.Log(array[i]);

        }
        Debug.Log("配列の逆の宣言です");
        for (int i = 3; i < array.Length; i--)
        {

            Debug.Log(array[i]);

        }
       
    }	
	// Update is called once per frame
	void Update () {
		
	}
   
}
