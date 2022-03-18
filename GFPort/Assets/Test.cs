using System.Collections;
using System.Collections.Generic;
using GameFramework.DataNode;
using UnityEngine;
using UnityGameFramework.Runtime;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        DataNodeManager dm = new DataNodeManager();
        var go123 = new GameObject("123");
        dm.SetData<VarGameObject>("a.b",go123);
        GameObject r1 = dm.GetData<VarGameObject>("a.b");
        Debug.LogError(r1.name);

        dm.SetData<VarString>("a.b","aaa");
        var str=dm.GetData<VarString>("a.b");

        Debug.LogError(str);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
