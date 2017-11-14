using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorTest : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RedChange() {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void GreenChange()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    public void BlueChange()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    public void LoadSence()
    {
        SceneManager.LoadScene("ChessGame");
    }
}
