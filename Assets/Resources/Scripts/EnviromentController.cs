using UnityEngine;
using System.Collections;

public class EnviromentController : MonoBehaviour
{
    public float spawnRate;
    public GameObject[] carTypes;
    public GameObject cloud;
    IEnumerator spawnCloud()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(cloud,new Vector3(cloud.transform.position.x , Random.Range(4.7f,6.8f),0),Quaternion.identity);
        StartCoroutine(spawnCloud());
    }
    IEnumerator spawnCar()
    {
        yield return new WaitForSeconds(spawnRate);
        Instantiate(carTypes[Random.Range(0, carTypes.Length)]);
        StartCoroutine(spawnCar());
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(spawnCar());
        StartCoroutine(spawnCloud());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
