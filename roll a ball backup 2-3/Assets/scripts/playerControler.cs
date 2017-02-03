using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerControler : MonoBehaviour {

	public float speed;
    public Text countText;
    public Text winText;
    public snake snk;

	private Rigidbody rb;
    public int count;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
        count = 0;
        SetCountText();
        winText.text = "";
	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement =new Vector3 (moveHorizontal,0,moveVertical);

		rb.AddForce (movement*speed);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText();
            snk.Upgrade();
        } 
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 30)
        {
            winText.text = "You Win!";
        }
    }
}
