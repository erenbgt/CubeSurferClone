using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStackController : MonoBehaviour
{
    public List<GameObject> cubeList = new List<GameObject>();
    private GameObject lastCubeObject;



    void Start()
    {
        UptadeLastCubeObject();
    }

    public void IncreaseCubeStack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastCubeObject.transform.position.x, lastCubeObject.transform.position.y - 2f, lastCubeObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        cubeList.Add(_gameObject);
        UptadeLastCubeObject();
    }

    public void DecreaseCubeStack(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        cubeList.Remove(_gameObject);
        UptadeLastCubeObject();
    }


    private void UptadeLastCubeObject()
    {
        lastCubeObject = cubeList[cubeList.Count - 1];
    }
}
