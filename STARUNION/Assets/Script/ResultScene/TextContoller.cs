using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextContoller : MonoBehaviour
{
    [SerializeField]
    Text score_text;
    int num;
    Score score = null;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Score");
        score = obj.GetComponent<Score>();
        num = score.GetScore();
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "SCORE" + num.ToString();
    }
}
