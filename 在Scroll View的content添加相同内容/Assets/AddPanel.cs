using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPanel : MonoBehaviour {

    public GameObject panel;
    GameObject Addpanel;//添加对象名称或者预制体的名称 
    private int panelNum = 0;


  // Use this for initialization
    void Start()
    {

        Addpanel = (GameObject)Resources.Load("Addpanel");

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void test1()
    {
        panelNum++;
        panel = Instantiate(Addpanel);
        panel.transform.SetParent(GameObject.Find("Content").transform);
        panel.transform.name = "panel" + panelNum;

       

    }
    public void RemoveAllListViewItem()
    {
        for (int i = 1; i <= panelNum; i++)
        {
            panel = GameObject.Find("panel" + i);
            Destroy(panel);
        }


    }
}
