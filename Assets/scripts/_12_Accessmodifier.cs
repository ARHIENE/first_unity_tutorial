using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _12_Accessmodifier : MonoBehaviour
{
    private int damage = 10;
    public float jumpSpeed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        //private        //public
        Debug.Log ("damage :" + damage );




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
