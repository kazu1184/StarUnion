using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    [SerializeField]
    List<GameObject> all_obj;
    GameObject pea_canvas;
    GameObject re_start;
    // Start is called before the first frame update
    void Start()
    {
        pea_canvas = GameObject.Find("Canvas");
        re_start = pea_canvas.transform.Find("ReStart").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<3;i++)
        {
            if(re_start.activeInHierarchy != false)
            {
                all_obj[i].SetActive(false);
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void Home()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
