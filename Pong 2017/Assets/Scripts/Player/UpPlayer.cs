using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPlayer : MonoBehaviour {

	public void upPlayer()
    {
        Input.GetKey(KeyCode.UpArrow);
    }
}
