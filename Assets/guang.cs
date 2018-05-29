using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guang : MonoBehaviour {

    public ParticleSystem guangqiu;
    public ParticleSystem guangyun;
    public ParticleSystem xingguang;
    bool co;

    // Use this for initialization
    void Start () {
        co = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if (GUI.Button(new Rect(200, 200, 80, 80), "change")){
            xingguang.startSize = (xingguang.startSize + 1) % 3;
            guangqiu.startColor = (co) ? Color.blue : Color.yellow;
            guangyun.startColor = (co) ? Color.yellow : Color.blue;
            co = !co;
        }
    }
}
