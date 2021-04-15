using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class BallRespawner : MonoBehaviour
{
    Transform startPos;
    GameObject ball;
    XRInteractionManager mgr;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform;
        ball = this.gameObject;
        mgr = GameObject.Find("XR Interaction Manager").GetComponent<XRInteractionManager>();
    }

    public void Respawn()
    {
        StartCoroutine(ReplaceBall());
    }
    IEnumerator ReplaceBall()
    {
        yield return new WaitForSeconds(5);
        this.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(.5f);
        ball = Instantiate(ball, startPos);
        ball.GetComponent<XRGrabInteractable>().interactionManager = mgr;
        ScoringMechanic.S.IncrementScore();
        Destroy(this.gameObject);
    }
}
