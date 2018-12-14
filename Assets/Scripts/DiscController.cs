using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscController : MonoBehaviour {

    public Manager manager;

    private SpriteRenderer spriteRen;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPosition(DiscGapController dgc)
    {
        Transform transform = dgc.GetComponent<Transform>();
        GetComponent<Transform>().position = transform.position;
    }

    public void SetSprite(Sprite spr)
    {
        spriteRen = GetComponent<SpriteRenderer>();
        spriteRen.sprite = spr;
    }

    public Sprite GetSprite()
    {
        spriteRen = GetComponent<SpriteRenderer>();
        return spriteRen.sprite;
    }
}
