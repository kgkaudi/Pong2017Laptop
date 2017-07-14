using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public void oneP () {
        Application.LoadLevel("1PlayerMode");
	}

    public void twoP()
    {
        Application.LoadLevel("2PlayerMode");
    }
}
