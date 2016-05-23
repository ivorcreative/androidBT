using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class btcontrol : MonoBehaviour {
    private Text txtAxesStat;
    private Text txtButtonStat;
            
	// Use this for initialization
	void Start () {
        SetInitials();
	}

    void SetInitials()
    {
        txtAxesStat = GameObject.Find("txtAxis").GetComponent<Text>();
        txtButtonStat = GameObject.Find("txtButton").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
            float  h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            txtAxesStat.text = "H1:" + h + "\nV1" + v;


        if (Input.GetButton("Fire1"))
            txtButtonStat.text = "Fire1";
        else if (Input.GetButton("Fire2"))
            txtButtonStat.text = "Fire2";
        else if (Input.GetButton("Fire3"))
            txtButtonStat.text = "Fire3";
        else
            txtButtonStat.text = "";
         

	}
}
