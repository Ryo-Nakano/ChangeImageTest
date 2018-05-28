using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageTest : MonoBehaviour {

	[SerializeField] Sprite unity;
	[SerializeField] Sprite c;
	[SerializeField] Sprite mario;

	[SerializeField] Text buttonCountText;

	GameObject image;
	SpriteRenderer spriteRenderer;

	int buttonCount;//ボタンを押した回数を保持しておく為の変数

	// Use this for initialization
	void Start () {
		image = GameObject.Find("Image");
		spriteRenderer = image.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void ChangeImageButton()
	{
		buttonCount++;
		buttonCountText.text = buttonCount.ToString();

		if(buttonCount % 3 == 0)//buttonCountが3の倍数の時
		{
			spriteRenderer.sprite = unity;
		}
		else
		{
			spriteRenderer.sprite = mario;
		}
	}
}
