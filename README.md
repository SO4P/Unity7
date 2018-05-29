+ 简单粒子制作
    + 按参考资源要求，制作一个粒子系统
    参照参考资料的说明建立一个粒子
    + 使用 3.3 节介绍，用代码控制使之在不同场景下效果不一样
    点击按钮可以切换粒子效果，可以调整光球颜色，星光的大小。

    + 粒子控制器
    ```
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
    ```
    + [演示视频](https://github.com/SO4P/Unity7/blob/master/%E6%BC%94%E7%A4%BA%E8%A7%86%E9%A2%91.zip)
