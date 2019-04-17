using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStarManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] star = new GameObject[6];
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<6;i++)
        {
            //描画OFF
            star[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnActive()
    {
        for (int i = 0; i < 6; i++)
        {
            //描画ON
            star[i].SetActive(true);
        }
    }
}
