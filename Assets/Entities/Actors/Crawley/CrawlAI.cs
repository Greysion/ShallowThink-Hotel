/* --------------------------------------------------------------------------------------------------------------------------------------------------------- //
   Author: 			Hayden Reeve
   Description: 	Acts as the variable handler for the SyntaxBug actor.
// --------------------------------------------------------------------------------------------------------------------------------------------------------- */

using System.Collections;
using UnityEngine;

public class CrawlAI : MonoBehaviour
{

    // Our basic configurable variables.
    [SerializeField] [Range(1, 99)] private float idleChance = 1f;
    [SerializeField] [Range(1, 99)] private float moveChance = 1f;
    [SerializeField] [Range(1, 99)] private float turnChance = 1f;

    [SerializeField] [Range(0.1f, 2f)] private float movementSpeed = 1f;

    // Our component Grabs.
    Animator myAnimator;
    SpriteRenderer mySprite;

    // Internal heavy-use variables for ease of access.
    private WaitForSeconds gameplayTick = new WaitForSeconds(1f);
    private Vector3 currentDirection = new Vector3(1, 0, 0);
    private bool moving = false;

    Coroutine myTicker;

    // Used for component grabs and early initialisation before the main start function.
    public void Awake() {

        myAnimator = GetComponent<Animator>();
        mySprite = GetComponent<SpriteRenderer>();

    }

    // Used for post-awake initialisation. Typically assigning variables and/or using components that have been attached.
    public void Start() {

        // Make sure if we've been flipped that we flip back around.
        if (mySprite.flipX)
            currentDirection *= -1;

        // Start our main gameplay tick.
        myTicker = StartCoroutine(GameplayTick()); 

    }

    // A fixed update cycle once per frame used as a common while(true) loops.
    //public void Update() {
        
    //}

    // A fixed update cycle once per frame used for animations and lerps without the need for DeltaTime.
    public void FixedUpdate() {

        // If we're moving, pick our current direction and move slowly towards it.
        if (moving) {

            myAnimator.transform.position = Vector2.MoveTowards(myAnimator.transform.position,
                myAnimator.transform.position + currentDirection,
                movementSpeed * Time.deltaTime);

        }

    }

    // Once per second gameplay tick. Anything in this enumerator will only be run once every second, rather than every frame or fixed frame.
    IEnumerator GameplayTick() {

        while (true) {

            if (Random.Range(1, 100) >= (moving ? moveChance : idleChance)) {
                myAnimator.SetBool("isMoving", moving = !moving);
            }

            if (Random.Range(1, 100) >= turnChance) {
                mySprite.flipX = !mySprite.flipX;
                currentDirection *= -1;
            }

            yield return gameplayTick;

        }

    }

}
