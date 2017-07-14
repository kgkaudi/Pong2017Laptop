using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownPlayer : MonoBehaviour {

    public void downPlayer()
    {
        Input.GetKey(KeyCode.DownArrow);
    }
}
