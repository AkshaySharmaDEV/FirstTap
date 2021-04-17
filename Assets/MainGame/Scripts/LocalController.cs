using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocalController : MonoBehaviour {

    public Button tap1;
    public Button tap2;
    public Button tap3;

    public TMP_Text timerMinutes;
    public TMP_Text timerSeconds;
    public TMP_Text timerSeconds100;

    public TMP_Text timerMinutes1;
    public TMP_Text timerSeconds1;
    public TMP_Text timerSeconds1001;

    public TMP_Text timerMinutes2;
    public TMP_Text timerSeconds2;
    public TMP_Text timerSeconds1002;

    public TMP_Text timerMinutes3;
    public TMP_Text timerSeconds3;
    public TMP_Text timerSeconds1003;

    private float startTime;
    private float stopTime;
    private float timerTime;

    private float startTime1;
    private float stopTime1;
    private float timerTime1;

    private float startTime2;
    private float stopTime2;
    private float timerTime2;

    private float startTime3;
    private float stopTime3;
    private float timerTime3;

    private bool isRunning = false;
    private bool isRunning1 = false;
    private bool isRunning2 = false;
    private bool isRunning3 = false;

	// Use this for initialization
	void Start () {
        TimerReset();
    }

    

    public void TimerStart() {
        if (!isRunning) {
            print("START");
            isRunning = true;
            TimerStart1();
            TimerStart2();
            TimerStart3();
            tap1.interactable = true;
            tap2.interactable = true;
            tap3.interactable = true;
            
        }
    }

    public void TimerStart1() {
        if (!isRunning1) {
            print("START");
            isRunning1 = true;
            startTime1 = Time.time;       
        }
    }

    public void TimerStart2() {
        if (!isRunning2) {
            print("START");
            isRunning2 = true;
            startTime2 = Time.time;       
        }
    }

    public void TimerStart3() {
        if (!isRunning3) {
            print("START");
            isRunning3 = true;
            startTime3 = Time.time;       
        }
    }

    




    public void TimerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = timerTime;
        }
    }

    public void TimerStop1()
    {
        if (isRunning1)
        {
            print("STOP");
            isRunning1 = false;
            stopTime1 = timerTime1;
        }
    }

    public void TimerStop2()
    {
        if (isRunning2)
        {
            print("STOP");
            isRunning2 = false;
            stopTime2 = timerTime2;
        }
    }

    public void TimerStop3()
    {
        if (isRunning3)
        {
            print("STOP");
            isRunning3 = false;
            stopTime3 = timerTime3;
        }
    }

    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        isRunning = false;
        timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }

    // Update is called once per frame
    void Update () {
        timerTime = stopTime + (Time.time - startTime);
        timerTime1 = stopTime1 + (Time.time - startTime1);
        timerTime2 = stopTime2 + (Time.time - startTime2);
        timerTime2 = stopTime2 + (Time.time - startTime2);




        int minutesInt = (int)timerTime / 60;
        int secondsInt = (int)timerTime % 60;
        int seconds100Int = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

        int minutesInt1 = (int)timerTime / 60;
        int secondsInt1 = (int)timerTime % 60;
        int seconds100Int1 = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

        int minutesInt2 = (int)timerTime / 60;
        int secondsInt2 = (int)timerTime % 60;
        int seconds100Int2 = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

        int minutesInt3 = (int)timerTime / 60;
        int secondsInt3 = (int)timerTime % 60;
        int seconds100Int3 = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));



        if (isRunning)
        {
            timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();

            // timerMinutes1.text = (minutesInt1 < 10) ? "0" + minutesInt1 : minutesInt1.ToString();
            // timerSeconds1.text = (secondsInt1 < 10) ? "0" + secondsInt1 : secondsInt1.ToString();
            // timerSeconds1001.text = (seconds100Int1 < 10) ? "0" + seconds100Int1 : seconds100Int1.ToString();

            // timerMinutes2.text = (minutesInt2 < 10) ? "0" + minutesInt2 : minutesInt2.ToString();
            // timerSeconds2.text = (secondsInt2 < 10) ? "0" + secondsInt2 : secondsInt2.ToString();
            // timerSeconds1002.text = (seconds100Int2 < 10) ? "0" + seconds100Int2 : seconds100Int2.ToString();

            // timerMinutes3.text = (minutesInt < 10) ? "0" + minutesInt2 : minutesInt2.ToString();
            // timerSeconds3.text = (secondsInt < 10) ? "0" + secondsInt2 : secondsInt2.ToString();
            // timerSeconds1003.text = (seconds100Int < 10) ? "0" + seconds100Int2 : seconds100Int2.ToString();
        }

        if (isRunning1)
        {
            

            timerMinutes1.text = (minutesInt1 < 10) ? "0" + minutesInt1 : minutesInt1.ToString();
            timerSeconds1.text = (secondsInt1 < 10) ? "0" + secondsInt1 : secondsInt1.ToString();
            timerSeconds1001.text = (seconds100Int1 < 10) ? "0" + seconds100Int1 : seconds100Int1.ToString();

            
        }

        if (isRunning2)
        {
            

            timerMinutes2.text = (minutesInt2 < 10) ? "0" + minutesInt2 : minutesInt2.ToString();
            timerSeconds2.text = (secondsInt2 < 10) ? "0" + secondsInt2 : secondsInt2.ToString();
            timerSeconds1002.text = (seconds100Int2 < 10) ? "0" + seconds100Int2 : seconds100Int2.ToString();

            
        }

        if (isRunning3)
        {
            

            timerMinutes3.text = (minutesInt3 < 10) ? "0" + minutesInt3 : minutesInt3.ToString();
            timerSeconds3.text = (secondsInt3 < 10) ? "0" + secondsInt3 : secondsInt3.ToString();
            timerSeconds1003.text = (seconds100Int3 < 10) ? "0" + seconds100Int3 : seconds100Int3.ToString();

            
        }
    }
}
