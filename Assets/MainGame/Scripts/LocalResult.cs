using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LocalResult : MonoBehaviour
{

    public TMP_Text player1timer1;
    public TMP_Text player1timer2;
    public TMP_Text player1timer3;

    public TMP_Text player2timer1;
    public TMP_Text player2timer2;
    public TMP_Text player2timer3;

    public TMP_Text player3timer1;
    public TMP_Text player3timer2;
    public TMP_Text player3timer3;

    public TMP_Text player4timer1;
    public TMP_Text player4timer2;
    public TMP_Text player4timer3;

    public TMP_Text Wintext;

    public TMP_Text player1name;
    public TMP_Text player2name;
    public TMP_Text player3name;
    public TMP_Text player4name;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Addition()
    {

        float score11 = float.Parse(player1timer1.text);
        float score12 = float.Parse(player1timer2.text);
        float score13 = float.Parse(player1timer3.text);

        float score21 = float.Parse(player2timer1.text);
        float score22 = float.Parse(player2timer2.text);
        float score23 = float.Parse(player2timer3.text);
        
        float score31 = float.Parse(player3timer1.text);
        float score32 = float.Parse(player3timer2.text);
        float score33 = float.Parse(player3timer3.text);

        float score41 = float.Parse(player4timer1.text);
        float score42 = float.Parse(player4timer2.text);
        float score43 = float.Parse(player4timer3.text);

        float score1 = score11 + score12 + score13;
        float score2 = score21 + score22 + score23;
        float score3 = score31 + score32 + score33;
        float score4 = score41 + score42 + score43;

        if(score1 < score2 && score1 < score3 && score1 < score4)
        {

            print("Player1Wins");
            Wintext.text = string.Format("{0} is the fastest player!",player1name.text);

        }
        else if(score2 < score3 && score2 < score4)
        {

            print("Player2Wins");
            Wintext.text = string.Format("{0} is the fastest player!",player2name.text);
            
        }
        else if(score3 < score4)
        {
            print("Player3wins");
            Wintext.text = string.Format("{0} is the fastest player!",player3name.text);

        }
        else
        {
            print("Player4wins");
            Wintext.text = string.Format("{0} is the fastest player!",player4name.text);
        }
        

    }
}
