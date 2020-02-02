/* --------------------------------------------------------------------------------------------------------------------------------------------------------- //
   Author: 			Hayden Reeve
   Description: 	For handling and distributing all core functions of clickable rooms for player interaction.
// --------------------------------------------------------------------------------------------------------------------------------------------------------- */

using System.Collections;
using UnityEngine;

public abstract class Room : MonoBehaviour
{

    // Inherent
    private Coroutine myTicker;
    private WaitForSeconds myTick = new WaitForSeconds(1f);

    // Use Start() for Default Values, setup functions, or other early requirements.
    void Start() {

        myTicker = StartCoroutine(GameplayTick());

    }

    public virtual IEnumerator GameplayTick() {

        while (true) {
            GenerateResource();
            yield return myTick;
        }

    }

    public virtual void Clicked() {

        GenerateResource();

    }

    public virtual void GenerateResource() {

        Debug.LogWarning("<b>Warning:</b> Tried to generate an undefined resource.");

    }


}
