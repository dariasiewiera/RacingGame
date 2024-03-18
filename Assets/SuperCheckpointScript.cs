using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class SuperCheckpointScript : MonoBehaviour
{
    public CheckpointScript cp1;
    public CheckpointScript cp2;
    public CheckpointScript cp3;
    public CheckpointScript cp4;
    public CheckpointScript cp5;
    public LogicScript logic;
    private float loopStartTime;
    public Text loopTimeText;


    
    void Start()
    {
        loopStartTime = Time.time; 
    }

    void Update()
    {
        // Oblicz czas trwania aktualnej pętli
        float loopTime = Time.time - loopStartTime;
        int minutes = Mathf.FloorToInt(loopTime / 60);
        int seconds = Mathf.FloorToInt(loopTime % 60);
        int milliseconds = Mathf.FloorToInt((loopTime * 1000) % 1000);
        string formattedTime = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        loopTimeText.text = formattedTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        float loopTime = Time.time - loopStartTime;



        if (cp1.getDone() && cp2.getDone() && cp3.getDone() && cp4.getDone() && cp5.getDone()) {
            if ( loopTime < logic.bestTime)
            {
                logic.bestTime = loopTime;
             
            }
            logic.addLoop();
            cp1.setDone(false);
            cp2.setDone(false);
            cp3.setDone(false);
            cp4.setDone(false);
            cp5.setDone(false);

            loopStartTime = Time.time;
        }
        
    }

   
}
