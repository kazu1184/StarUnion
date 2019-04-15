using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialRespawn : MonoBehaviour
{
    bool ok_flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetFlag()
    {
        return ok_flag;
    }

    //当たっているとき値を入れる
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Triangle")
        {
            ok_flag = false;
        }
    }

    //外れたらnull
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Triangle")
        {
            ok_flag = true;
        }
    }
}
