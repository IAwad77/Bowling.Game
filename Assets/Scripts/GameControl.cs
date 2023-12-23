using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject firstballObject;
    public GameObject secondballObject;
    public GameObject thirdballObject;
    public GameObject pinsObject;

    public Vector3 firstBallPos;
    public Vector3 secondBallPos;
    public Vector3 thirdBallPos;
    public Vector3 pinsPos;

    public GameObject pinsPrefab;


    private void Start()
    {
        firstBallPos = firstballObject.transform.position;
        secondBallPos = secondballObject.transform.position;
        thirdBallPos = thirdballObject.transform.position;
        pinsPos = pinsObject.transform.position;
    }

    public void ResetObjects()
    {
        firstballObject.transform.position = firstBallPos;
        secondballObject.transform.position = secondBallPos;
        thirdballObject.transform.position= thirdBallPos;
        pinsObject.transform.position= pinsPos;

        Destroy(pinsObject);

        pinsObject = Instantiate(pinsPrefab, pinsPos, Quaternion.identity);
    }
}
