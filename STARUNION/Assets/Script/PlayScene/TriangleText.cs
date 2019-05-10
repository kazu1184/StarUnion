using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriangleText : MonoBehaviour
{
    [SerializeField]
    Text num_tri;
    //音用
    [SerializeField]
    AudioClip audio_clip;
    AudioSource audio_source;
    int num; 

    // Start is called before the first frame update
    void Start()
    {
        GameObject main_camera = GameObject.Find("Main Camera");
        audio_source = main_camera.GetComponent<AudioSource>();
        Debug.Log(audio_source);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //テキストのセット
    public void SetText(string newText)
    {
        num_tri.text = newText;
    }
    //テキストの取得
    public string GetText()
    {
        return num_tri.text;
    }
    //数字のセット
    public void SetNum(int num)
    {
        this.num = num;
    }
    //数字の取得
    public int GetNum()
    {
        return this.num;
    }

    //音を鳴らす
    public void OnAudio()
    {
        audio_source.PlayOneShot(audio_clip);
        Debug.Log(audio_clip);
    }
}
