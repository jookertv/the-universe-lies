using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ramp : MonoBehaviour {

    public playerControler pc;

    private bool rotate = false;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (pc.count >= 15)
        {
            if (rotate == false)
            {
                transform.Rotate(new Vector3(72, 0, 0));
                rotate = true;
            }
        }
	}
}
