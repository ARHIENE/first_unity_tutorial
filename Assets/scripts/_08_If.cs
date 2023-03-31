using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _08_If : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int coin = 500;
        int item1 = 1000;
        int item2 = 200;

        if(coin >= item1){
            Debug.Log("item1 구매했어용~");
            coin -= item1;
        }
        Debug.Log("coin : " + coin);
        Debug.Log("===========================");


        if(coin >= item2){
            Debug.Log("item2 구매했어용~");
            coin -= item2;
        }
        Debug.Log("coin : " + coin); // 300원
        Debug.Log("===========================");



        coin = 500;
        if (coin >= item1){
            Debug.Log("item1 구매했어용~");
            coin -= item1;
        }
        else { 
            Debug.Log("그지네 돈없어서 이것도 못사누 ㅋㅋ");
            Debug.Log("coin : " + coin);
        }
        if (coin >= item2){
            Debug.Log("item2 구매했어용~");
            coin -= item2;
        }
        else { 
            Debug.Log("그지네 돈없어서 이것도 못사누 ㅋㅋ");
            
        }
            Debug.Log("coin : " + coin);
            Debug.Log("=============================");

        coin = 500;

        if (coin >= item1){
            Debug.Log("item1 구매할게용~");
            coin -= item1;
        }
        else if(coin >= item2){
            Debug.Log("아이템2라도 살게용~");
            coin -= item2;
        }
            Debug.Log("coin : " + coin);
            Debug.Log("=============================");


        coin = 100;

        if (coin >= item1){
            Debug.Log("item1 구매할게용~");
            coin -= item1;
        }
        else if(coin >= item2){
            Debug.Log("아이템2라도 살게용~");
            coin -= item2;
        }
        else{
            Debug.Log("아니 싯팔 " + coin + "원밖에 없으면서 뭘사러온거임");

        }
                    Debug.Log("=============================");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
