using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class  ScoreGenerator:MonoBehaviour
{
    int score = 0;

    
    private GameObject Scoretxt;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.Scoretxt = GameObject.Find("ScoreText");
        this.Scoretxt.GetComponent<Text>().text = score.ToString();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
            this.Scoretxt.GetComponent<Text>().text = score.ToString();
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
            this.Scoretxt.GetComponent<Text>().text = score.ToString();
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 40;
            this.Scoretxt.GetComponent<Text>().text = score.ToString();
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 120;
            this.Scoretxt.GetComponent<Text>().text = score.ToString();
        }
    }



    // Update is called once per frame
    void Update()
    {



    }
}