using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _07_String : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string s1 = "Game";
        string s2 = "start";
        string s3 = "Over";

        Debug.Log(s1 + s2); // Game Start
        Debug.Log(s1 + s3); // Game over

        Debug.Log(s1 + " " + s2);
        Debug.Log(s1 + " " + s3);

        Debug.Log(s1.Length); // 4 - 문자열 길이
        Debug.Log(s1.ToLower()); // 소문자로 바꾸기 game
        Debug.Log(s1.ToUpper()); // 대문자로 바꾸기 GAME
        Debug.Log(s1.IndexOf("m")); // m이 어디있는지 찾기 = >0부터 시작해서 m은 Game에서 2번째임 0 , 1, 2임
        Debug.Log(s1[2]); //s1에서 2번째 인덱스에 있는 영어 찾기 m이나옴
        Debug.Log(s1.Substring(2)); // m,e 가 출력됨 2번째부터 자른거임

        s1 = "player";
        s2 = "enemy1";
        s3 = "enemy2";

        Debug.Log(s1 == "player"); // true
        Debug.Log(s2 == "enemy"); // false
        Debug.Log(s2.Contains("enemy")); // enemy를 포함하고있니 true
        Debug.Log(s3.StartsWith("en")); //en으로 시작하나요? true
        Debug.Log(s1.EndsWith("er")); // er로 끝이나나요? true

        Debug.Log("Game");
        Debug.Log("Over");
        Debug.Log("Game\nOver"); // new line
        Debug.Log("Game\t\t\tOver");// \t = tab임
        Debug.Log("\"Good Game\""); // 큰따옴표로 감싸는법
        Debug.Log("\'Good Game\'"); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
