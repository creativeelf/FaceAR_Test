using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCube : MonoBehaviour {

    private GameObject target;
    public GameObject sceneManager;

	// Use this for initialization
	void Start () {
        target = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        target.transform.localPosition = sceneManager.GetComponent<ScoreClient>().GetPosition();
        target.transform.localEulerAngles = sceneManager.GetComponent<ScoreClient>().GetRotation();
	}
}
