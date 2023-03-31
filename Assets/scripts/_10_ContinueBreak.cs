using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_ContinueBreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //continue
        for (int i = 1; i <= 5; i++){
            if(i == 3){
                continue;

            }
            Debug.Log("Enemy" + i + "took damage");

        }
        Debug.Log("==================================");


        //break
        for (int i = 1; i <= 5; i++){
            if(i == 3){
                Debug.Log("boss is dead");
                break;
        }
        Debug.Log("enemy" + i + "is dead");
    }
    Debug.Log("suc섹스");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
