using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugLogs : MonoBehaviour
{
    public bool isDebug;

    public Canvas debugLogs;
    public Text momentumX;
    public Text isGround;
    public Text velocity;
    public Text isSprint;
    public Text momentumLog;
    public Text walls;
    public Text wallJumpTime;
    public Text wallRun;
    public Text isLedge;
    public Text isSlide;
    public Text isFallStun;
    public Text fallStunTime;
    public Text rollTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")){
            isDebug = !isDebug;
        }
        if(isDebug){
            debugLogs.enabled = true;
        }else{
         debugLogs.enabled = false;
        }
    }

    public void DebugText(string s, string v){
        switch(s){
            case "momentumX":
                momentumX.text = v;
                break;
            case "momentumLog":
                momentumLog.text = v;
                break;
            case "isGround":
                isGround.text = v;
                break;
            case "isSprint":
                isSprint.text = v;
                break;
            case "velocity":
                velocity.text = v;
                break;
            case "walls":
                walls.text = v;
                break;
            case "wallJumpTime":
                wallJumpTime.text = v;
                break;
            case "wallRun":
                wallRun.text = v;
                break;
            case "isLedge":
                isLedge.text = v;
                break;
            case "isSlide":
                isSlide.text = v;
                break;
            case "isFallStun":
                isFallStun.text = v;
                break;
            case "fallStunTime":
                fallStunTime.text = v;
                break;
            case "rollTime":
                rollTime.text = v;
                break;
        }
    }
}
