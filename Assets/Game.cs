using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Game : MonoBehaviour
{

	private int count;
    private Rigidbody rb; 
	public TextMeshProUGUI countText;


    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent <Rigidbody>(); 
	count = 0; 
	SetCountText();
    }

    void SetCountText() 
	{
	countText.text =  "Count: " + count.ToString() + "/5";
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
