using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckpointScript : MonoBehaviour
{
    private bool done = false;
    public CheckpointScript previous;
    public SuperCheckpointScript super;

    public LogicScript logic;
    

    private void OnTriggerEnter(Collider other)
    {
       
      done = true; 
        
    }

    public bool getDone()
    {
        return done;
    }

    public void setDone(bool x)
    {
        done = x;
    }
}
