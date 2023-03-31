using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _15_Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     /*   string playerName = "Lion";
        int playerHp = 100;
        int playerdamage = 30;

        string enemyName = "Enemy1";
        int enemyHp = 30;
        int enemyDamage = 5;
        */


        character player = new character();
        player.name = "Lion";
        player.hp = 100;
        player.damage = 30;

        character enemy = new character();
        enemy.name = "enemy1";
        enemy.hp = 30;
        enemy.damage = 5;



        /*
        TakeDamage(playerName, playerHp, enemyDamage);
        TakeDamage(enemyName, enemyHp, playerdamage);
        */

        player.TakeDamage(enemy.damage);
        Debug.Log("==================================");
        enemy.TakeDamage(player.damage);
        Debug.Log("==================================");

        character boss = new character("boss", 1000, 50);
        boss.TakeDamage(player.damage);
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
