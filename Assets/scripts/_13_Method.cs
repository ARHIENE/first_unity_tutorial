using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _13_Method : MonoBehaviour
{
    void StartGame(){
        Debug.Log("game start");

    }

    void EnemyTakeDamage(string name){
        Debug.Log(name + "takes damage");

    }

    void PlayerTakeDamage(string name, int hp, int damage){
        hp -= damage;
        Debug.Log(name + "takes damage" + damage);
        Debug.Log(name + "hp : " + hp);
    }

    int BossTakeDamage(int hp, int damage){
        hp -= damage;
        Debug.Log("Boss takes damage" + damage);
        return hp; 
    }

    string GetPlayerName(){
        return "Lion";
    }



    // Start is called before the first frame update
    void Start()
    {
        StartGame();
        EnemyTakeDamage("Enemy1");
        EnemyTakeDamage("Enemy2");
        Debug.Log("==================================");

        string PlayerName = GetPlayerName();
        Debug.Log("player" + PlayerName);
        Debug.Log("==================================");


        PlayerTakeDamage(PlayerName, 100 , 10); // name, hp, damage
        Debug.Log("==================================");

        int hp = BossTakeDamage(1000,50);
        Debug.Log("boss hp : " + hp);


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
