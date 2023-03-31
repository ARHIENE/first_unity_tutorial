using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _11_Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int enemy1 = 10;
        int enemy2 = 20;
        int enemy3 = 30;

        Debug.Log(enemy1);
        Debug.Log(enemy2);
        Debug.Log(enemy3);
        Debug.Log("=================");

        int[] enemies = {10,20,30};
        Debug.Log(enemies[0]); // 10
        Debug.Log(enemies[1]); // 20
        Debug.Log(enemies[2]); // 30
        Debug.Log("=================");

        string[] characters = new string[3];
        characters[0] = "dog";
        characters[1] = "cat";
        characters[2] = "라이옹";


        for(int i = 0; i < characters.Length; i++){
            Debug.Log(characters[i]); // dog cat 라이옹
        }
        Debug.Log("=================");

        characters[2] = "rabbit";
        foreach (string character in characters) {
            Debug.Log(character); // dog cat rabbit
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
