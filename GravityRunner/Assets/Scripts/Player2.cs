using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    bool safety = true;

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5);
        safety = true;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            if (safety)
            {
                Physics.gravity *= -1;
                safety = false;
            } else
            {
                StartCoroutine(Cooldown());
            }
        }
    }
}