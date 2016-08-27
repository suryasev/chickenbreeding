using UnityEngine;
using System.Collections.Generic;

public class Plot : MonoBehaviour {

    GameObject breedLeft;
    GameObject breedRight;

    List<GameObject> babies = new List<GameObject>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Breed()
    {
        if (breedLeft != null && breedRight != null)
        {
            Animal leftAnimal = breedLeft.GetComponent<Animal>();
            Animal rightAnimal = breedRight.GetComponent<Animal>();
            if (leftAnimal != null && rightAnimal != null)
            {
                babies.Add(leftAnimal.breedWith(rightAnimal));
            }
        }
    }
}
