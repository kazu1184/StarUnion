using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonContoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ホーム
    public void Home()
    {
        SceneManager.LoadScene("TitleScene");
    }

    //もう一度
    public void Return()
    {
        SceneManager.LoadScene("PlayScene");
    }

    //次のステージ
    public void NextStage()
    {
        //シーンの更新
        SharedData.instance.num_stage += 1;

        SceneManager.LoadScene("PlayScene");
    }
}
