using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    //星の色を変える
    [SerializeField]
    ClearStarManager csm;
    //インスタンス用
    GameObject[] star;
    //速度
    Vector3[] vel;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AnimationClear()
    {
        //星を光らせる
        csm.OnActive();
    }
}
