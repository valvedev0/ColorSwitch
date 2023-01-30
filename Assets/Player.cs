using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	public float jumpforce = 10f;

	public Rigidbody2D rb;
	
	public  string currentcolor;

	public SpriteRenderer sr;

	public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;

    void Start ()
	{

		SetRandomColor();

	}


	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0) ) {

			rb.velocity = Vector2.up * jumpforce; 
		}

		
	

	}

	void OnTriggerEnter2D (Collider2D col) {


		if(col.tag == "ColorChanger")
		{
			SetRandomColor();
		    Destroy(col.gameObject);
			return;


		}

		if(col.tag != currentcolor)
		{
            Debug.Log("gAMEoVER");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

		
	}

	void SetRandomColor()
	{

		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentcolor = "Cyan";
				sr.color= colorCyan;
				break;

            case 1:
                currentcolor = "Yellow";
				sr.color= colorYellow;
                break;

            case 2:
                currentcolor = "Magenta";
				sr.color= colorMagenta;
                break;

            case 3:
                currentcolor = "Pink";
				sr.color= colorPink;
                break;
        }
	}
}
