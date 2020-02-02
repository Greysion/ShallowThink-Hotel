using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyRoom : Room
{

	public override void Clicked() {
		return;
	}

	public override IEnumerator GameplayTick() {
		Debug.LogWarning("<b>Warning:</b> Tried to loop through a gameplay tick on a null room.");
		yield break;
	}

	public override void GenerateResource() {
		Debug.LogWarning("<b>Warning:</b> Tried to generate a resource on a null room.");
		return;
	}

}
