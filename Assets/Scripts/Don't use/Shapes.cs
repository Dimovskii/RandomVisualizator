using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    [SerializeField] private GameObject[] _shapes;
    public static GameObject _shapePrefab;

    public void RandomChoseShape()
    {
        int indexShape = Random.Range(0, _shapes.Length);
        var shape = _shapes[indexShape];
        _shapePrefab = shape;
    }
}
