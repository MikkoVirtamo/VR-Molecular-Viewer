using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moleculeSelection : MonoBehaviour {
    [SerializeField]
    private GameObject[] molecules;

    [SerializeField]
    private GameObject selector;
    
    //private GameObject current;
	// Use this for initialization
	void Start () {
        selector.transform.localScale = new Vector3(1, 1, 1);
        molecules[0].SetActive(false);
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
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //This was for testing using keyboard
            selector.transform.Rotate(0, 90, 0);
        }
	}

    public void acetylcholinePressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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
    }

    public void acetylcholineDrugPressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
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
    }

    public void acidAlphaPressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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
    }

    public void acidAlphaDrugPressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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
    }

    public void beta2Pressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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
    }

    public void beta2DrugPressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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
    }

    public void carbonicPressed()
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                selector.transform.localScale = new Vector3(1, 1, 1);
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
        }

    public void carbonicDrugPressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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
    }

    public void cycloPressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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
    }

    public void cycloDrugPressed()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            selector.transform.localScale = new Vector3(1, 1, 1);
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

    public void scaleUp()
    {
        selector.transform.localScale += new Vector3(1, 1, 1);
    }

    public void scaledown()
    {
        if (selector.transform.localScale != new Vector3(0, 0, 0))
        {
            selector.transform.localScale -= new Vector3(1, 1, 1);
        }
    }

    public void rotateRight()
    {
        selector.transform.Rotate(0, 90, 0);
    }
    public void rotateLeft()
    {
        selector.transform.Rotate(0, -90, 0);
    }

}

