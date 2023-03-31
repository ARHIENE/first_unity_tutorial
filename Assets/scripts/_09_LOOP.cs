using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_LOOP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int coin = 0;
        coin += 1;
        Debug.Log("남은코인" + coin);
        coin += 1;
        Debug.Log("남은코인" + coin);
        coin += 1;
        Debug.Log("남은코인" + coin);
        coin += 1;
        Debug.Log("남은코인" + coin);
        Debug.Log("=================================");

        coin = 0;
        for(int i = 0; i < 5 ; i++){
            coin += 1;
            Debug.Log("coin : " + coin);


        }
        Debug.Log("=====================================");

        for(int time = 5; time >= 0; time--){
            Debug.Log("time" + time);
        }
        Debug.Log("===============================");


        for(int i = 1; i< 10; i += 2){
            Debug.Log("num : " + i);

        }
        Debug.Log("===============================");

        int hp = 100;
        int damage = 15;
        while (hp >= 0){
            Debug.Log("hp" + hp);
            Debug.Log(damage + "damaged!!!!!!!!");
            hp -= damage;
        }


        //foreach 쓰는법
        string code = "CODE";
        foreach(char c in code) {
            Debug.Log(c);


        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
