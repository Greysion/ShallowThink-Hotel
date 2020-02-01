using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicCokieFunctintion : MonoBehaviour
{
    public static int CookieCount;
    public GameObject CookieDisplay;
    public int internalCookie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalCookie = CookieCount;
        CookieDisplay.GetComponent<Text>().text = "Cookies " + internalCookie;
    }
}
