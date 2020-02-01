using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public bool creatingcookie = false;


    void Update()
    {
        if(creatingcookie == false)
        {
            StartCoroutine(createcookiesAuto());
            creatingcookie = true;
        }
    }

    IEnumerator createcookiesAuto()
    {
        BasicCokieFunctintion.CookieCount += 1;
        yield return new WaitForSeconds(1);
        creatingcookie = false;
    }

   
}
