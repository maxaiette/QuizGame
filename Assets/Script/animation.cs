using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    
    public GameObject spashwhite;
    public GameObject splashText;    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SplashEnd());
    }

    // Update is called once per frame
   IEnumerator SplashEnd()
   {
    yield return new WaitForSeconds(6);
    spashwhite.SetActive(false);
    splashText.SetActive(false);
   }
}
