using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _14_Class : MonoBehaviour
{
    void TakeDamage(string name, int hp, int damage){
        hp -= damage;
        Debug.Log(name + "takes damage" + damage);
        Debug.Log(name + "hp : " + hp);


    }
    // Start is called before the first frame update
    void Start()
    {
        string playerName = "Lion";
        int playerHp = 100;
        int playerdamage = 30;

        string enemyName = "Enemy1";
        int enemyHp = 30;
        int enemyDamage = 5;

        TakeDamage(playerName, playerHp, enemyDamage);
        Debug.Log("==================================");
        TakeDamage(enemyName, enemyHp, playerdamage);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class character{
    public string name;
    public int hp;
    public int damage;

    public character(){
        Debug.Log("--default constructor-");
    }

    public character(string name, int hp, int damage){
    Debug.Log("-custom constructor -");
    this.name = name;
    this.hp = hp;
    this.damage = damage;
    }

    /*public void TakeDamage(int amount){
        hp -= amount;
        Debug.Log(name + "takes damage" + amount);
        Debug.Log(name + "hp : " + hp);


    }
*/
    public void TakeDamage(int damage){
        this.hp -= damage;
        Debug.Log(this.name + "takes damage" + damage);
        Debug.Log(this.name + "hp : " + this.hp);

    }
}
