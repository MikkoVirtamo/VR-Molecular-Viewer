using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moleculesWithKeys : MonoBehaviour {
    [SerializeField]
    private GameObject[] molecules;

    [SerializeField]
    private GameObject selector;
    // Use this for initialization
    void Start () {
        selector.transform.localScale = new Vector3(1, 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selector.transform.localScale = new Vector3(2, 2, 2);
            molecules[0].SetActive(true);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
            molecules[0].SetActive(false);
            molecules[1].SetActive(true);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(true);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(true);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(true);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(true);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(true);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(true);
            molecules[8].SetActive(false);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(true);
            molecules[9].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            molecules[0].SetActive(false);
            molecules[1].SetActive(false);
            molecules[2].SetActive(false);
            molecules[3].SetActive(false);
            molecules[4].SetActive(false);
            molecules[5].SetActive(false);
            molecules[6].SetActive(false);
            molecules[7].SetActive(false);
            molecules[8].SetActive(false);
            molecules[9].SetActive(true);
        }
    }
}
