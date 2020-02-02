/* --------------------------------------------------------------------------------------------------------------------------------------------------------- //
   Author: 			Hayden Reeve
   Description: 	Sole purpose to make instantiation easier by containing preset references to 
// --------------------------------------------------------------------------------------------------------------------------------------------------------- */

using UnityEngine;

public class ComponentData : MonoBehaviour
{

    [SerializeField] public SpriteRenderer myBackground;
    [SerializeField] public SpriteRenderer myForeground;
    [SerializeField] public SpriteRenderer myShadow;

    public void Finished() {
        Destroy(this);
    }

}
