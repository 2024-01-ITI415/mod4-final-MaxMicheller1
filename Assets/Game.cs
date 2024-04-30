using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

	private int count;
    private Rigidbody rb; 
	public txt countText;


    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent <Rigidbody>(); 
	count = 0; 
	SetCountText();
    }

    void SetCountText() 
	{
	countText =  "Count: " + count.ToString();
	if (count == 20)
		{
			// winTextObject.SetActive(true);
		}
	
	}

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter(Collider other) 
	{
	if (other.gameObject.CompareTag("PickUp")) 
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}
}
