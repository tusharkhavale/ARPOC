using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class CharacterController : MonoBehaviour {

	Animation anim;

	void Start()
	{
		anim = transform.GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (anim.isPlaying)
			return;

		if (Input.touches.Length > 3)
			anim.Play ("Death");
		else if (Input.touches.Length > 2)
			anim.Play ("Knockback");
		else if (Input.touches.Length > 1)
			anim.Play ("Attack");
		else if (Input.touches.Length > 0)
			anim.Play ("Skill");


//		string test = string.Empty;
//
//		Dictionary <string,string> dict = new Dictionary<string, string> ();
//
//		dict.

	}
}
