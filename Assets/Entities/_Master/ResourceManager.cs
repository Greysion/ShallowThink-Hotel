using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{

    // The various resources the player is required to manage. These are captured by the rooms and controlled remotely.
    public float resourceBytes;
    public float resourceBandwidth;
    public float resourceCodeLines;
    public float resourceCrawlers;

    // Snapshot references of all of the objects in our scenes.
    public List<GameObject> listOfCrawlers = new List<GameObject>();

    // Start is called before the first frame update
    void Start() {
        


    }

    // Update is called once per frame
    void Update() {
        


    }
}
