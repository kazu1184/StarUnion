using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    readonly int NUM_STAR = 10;

    [SerializeField]
    GameObject pr_star;
    GameObject[] star;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AnimationClear()
    {
        bool flag = false;
        star = new GameObject[NUM_STAR];

        for(int i=0;i<NUM_STAR;i++)
        {
            star[i] = Instantiate(pr_star) as GameObject;


        }

        return flag;
    }
}
