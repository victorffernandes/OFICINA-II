using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {
    public float spawnRate;
    public GameObject[] carTypes;
    IEnumerator spawn()
    {
        yield return new WaitForSeconds(spawnRate);
        Instantiate(carTypes[Random.Range(0, carTypes.Length)]);
        StartCoroutine(spawn());
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
