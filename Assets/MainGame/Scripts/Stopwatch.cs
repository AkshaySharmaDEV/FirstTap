using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Stopwatch : MonoBehaviour
{
    public TMP_Text round1time;
    public TMP_Text round1time1;
    public TMP_Text round1time2;
    

    public TMP_Text Wrong;
    public TMP_Text Wrong1;
    public TMP_Text Wrong2;
    
    public float sec = 15f;
    public GameObject Yes;
    public GameObject No;

    public GameObject Pyes1;
    public GameObject Pno1;
    public GameObject Pyes2;
    public GameObject Pno2;
    public GameObject Pyes3;
    public GameObject Pno3;

    public GameObject P1yes1;
    public GameObject P1no1;
    public GameObject P1yes2;
    public GameObject P1no2;
    public GameObject P1yes3;
    public GameObject P1no3;

    public GameObject P2yes1;
    public GameObject P2no1;
    public GameObject P2yes2;
    public GameObject P2no2;
    public GameObject P2yes3;
    public GameObject P2no3;

    public GameObject P3yes1;
    public GameObject P3no1;
    public GameObject P3yes2;
    public GameObject P3no2;
    public GameObject P3yes3;
    public GameObject P3no3;


    public TMP_Text playername;
    public TMP_Text playername1;
    public TMP_Text playername2;
    public TMP_Text playername3;

    public TMP_Text playerlabel;
    public TMP_Text playerlabel1;
    public TMP_Text playerlabel2;
    public TMP_Text playerlabel3;

    public Button tap1;
    public Button tap2;
    public Button tap3;

    bool stopwatchActive = false;
    bool stopwatchActive1 = false;
    bool stopwatchActive2 = false;
    bool stopwatchActive3 = false;

    float currentTime;
    float currentTime1;
    float currentTime2;
    float currentTime3;

    public int startMinutes;
    public int startMinutes1;
    public int startMinutes2;
    public int startMinutes3;


    public TMP_Text currentTimeText;
    public TMP_Text currentTimeText1;
    public TMP_Text currentTimeText2;
    public TMP_Text currentTimeText3;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;


        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(stopwatchActive == true) {
            currentTime = currentTime + Time.deltaTime;

        }
        if(stopwatchActive1 == true) {
            currentTime1 = currentTime1 + Time.deltaTime;

        }
        if(stopwatchActive2 == true) {
            currentTime2 = currentTime2 + Time.deltaTime;

        }
        if(stopwatchActive3 == true) {
            currentTime3 = currentTime3 + Time.deltaTime;

        }


        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        TimeSpan time1 = TimeSpan.FromSeconds(currentTime1);
        TimeSpan time2 = TimeSpan.FromSeconds(currentTime2);
        TimeSpan time3 = TimeSpan.FromSeconds(currentTime3);
        
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
        currentTimeText1.text = time1.ToString(@"mm\:ss\:fff");
        currentTimeText2.text = time2.ToString(@"mm\:ss\:fff");
        currentTimeText3.text = time3.ToString(@"mm\:ss\:fff");





        



        

        
        
        
    }

    

    public void CheckFast()
    {
        if(currentTime1 < currentTime2 && currentTime1 < currentTime3)
        {
            print("player2");
            playerlabel.text = string.Format("{0} is first to tap!", playername1.text);
            playerlabel1.text = string.Format("{0} is first to tap!", playername1.text);
            playerlabel2.text = string.Format("{0} is first to tap!", playername1.text);
            playerlabel3.text = string.Format("{0} is first to tap!", playername1.text);
            

        }
        else if(currentTime2 < currentTime3)
        {
            print("player3");
            playerlabel.text = string.Format("{0} is first to tap!", playername2.text);
            playerlabel1.text = string.Format("{0} is first to tap!", playername2.text);
            playerlabel2.text = string.Format("{0} is first to tap!", playername2.text);
            playerlabel3.text = string.Format("{0} is first to tap!", playername2.text);

        }
        else if(currentTime3 < currentTime1 && currentTime3 < currentTime2)
        {
            print("player4");
            playerlabel.text = string.Format("{0} is first to tap!", playername3.text);
            playerlabel1.text = string.Format("{0} is first to tap!", playername3.text);
            playerlabel2.text = string.Format("{0} is first to tap!", playername3.text);
            playerlabel3.text = string.Format("{0} is first to tap!", playername3.text);
            
        }

        else
        {

            
            
        }

        



    }

    

    public void GetName()
    {

        playerlabel.text = string.Format("{0} turns to speak!", playername.text);
        playerlabel1.text = string.Format("{0} turns to speak!", playername.text);
        playerlabel2.text = string.Format("{0} turns to speak!", playername.text);
        playerlabel3.text = string.Format("{0} turns to speak!", playername.text);

    }



    public void StartStopwatch()
    {
        stopwatchActive = true;
        StartStopwatch1();
        StartStopwatch2();
        StartStopwatch3();
        
        tap1.interactable = true;
        tap2.interactable = true;
        tap3.interactable = true;

        playerlabel.text = string.Format("{0} Get ready for Round1!", playername.text);
        playerlabel1.text = string.Format("{0} Get ready for Round1!", playername1.text);
        playerlabel2.text = string.Format("{0} Get ready for Round1!", playername2.text);
        playerlabel3.text = string.Format("{0} Get ready for Round1!", playername3.text);

        StartCoroutine(LateCall());

        
        

        

        
    }


    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        Yes.SetActive(true);
        No.SetActive(true);
        playerlabel.text = string.Format("{0} is that sentance is correct?", playername.text);
        
        //Do Function here...
    }

    public void GivePoints()
    {
        if(!tap1.IsInteractable())
        {
            // Pyes1.SetActive(true);
            P1yes1.SetActive(true);
            print("Working1");


        }
        else
        {

            P1no1.SetActive(true);
            string wrg = "-1";
            PlayerPrefs.SetString("wrong",wrg);
            Wrong.text = PlayerPrefs.GetString("wrong");
            
        }

        if(!tap2.IsInteractable())
        {
            // Pyes1.SetActive(true);
            P2yes1.SetActive(true);
            print("Working2");


        }
        else
        {

            P2no1.SetActive(true);
            string wrg1 = "-1";
            PlayerPrefs.SetString("wrong1",wrg1);
            Wrong1.text = PlayerPrefs.GetString("wrong1");
            
        }

        if(!tap3.IsInteractable())
        {
            // Pyes1.SetActive(true);
            P3yes1.SetActive(true);
            print("Working3");


        }
        else
        {

            P3no1.SetActive(true);
            string wrg2 = "-1";
            PlayerPrefs.SetString("wrong2",wrg2);
            Wrong2.text = PlayerPrefs.GetString("wrong2");
            
        }
    }


    public void WrongPoints()
    {
        if(!tap1.IsInteractable())
        {
            // Pyes1.SetActive(true);
            P1no1.SetActive(true);
            print("Working1");
            string wrg4 = "-1";
            PlayerPrefs.SetString("wrong4",wrg4);
            Wrong.text = PlayerPrefs.GetString("wrong4");


        }
        else
        {

            P1yes1.SetActive(true);

            
        }

        if(!tap2.IsInteractable())
        {
            // Pyes1.SetActive(true);
            P2no1.SetActive(true);
            print("Working2");
            string wrg5 = "-1";
            PlayerPrefs.SetString("wrong5",wrg5);
            Wrong1.text = PlayerPrefs.GetString("wrong5");


        }
        else
        {

            P2yes1.SetActive(true);
            
        }

        if(!tap3.IsInteractable())
        {
            // Pyes1.SetActive(true);
            P3no1.SetActive(true);
            print("Working3");
            string wrg6 = "-1";
            PlayerPrefs.SetString("wrong6",wrg6);
            Wrong2.text = PlayerPrefs.GetString("wrong6");


        }
        else
        {

            P3yes1.SetActive(true);
            
        }
    }

    public void StartStopwatch1()
    {
        stopwatchActive1 = true;
    }

    public void StartStopwatch2()
    {
        stopwatchActive2 = true;
    }

    public void StartStopwatch3()
    {
        stopwatchActive3 = true;
    }



    public void StopStopwatch()
    {
        stopwatchActive = false;   
    }

    public void StopStopwatch1()
    {
        stopwatchActive1 = false;   
        PlayerPrefs.SetFloat("time",currentTime1);
        round1time.text = PlayerPrefs.GetFloat("time").ToString();

    }

    

    public void StopStopwatch2()
    {
        stopwatchActive2 = false;   
        PlayerPrefs.SetFloat("time1",currentTime2);
        round1time1.text = PlayerPrefs.GetFloat("time1").ToString();
    }
    public void StopStopwatch3()
    {
        stopwatchActive3 = false;  
        PlayerPrefs.SetFloat("time2",currentTime3);
        round1time2.text = PlayerPrefs.GetFloat("time2").ToString();
    }
}
