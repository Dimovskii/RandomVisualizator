using UnityEngine;
using System.Collections.Generic;

public enum FigureType
{
    circle,
    square,
    triagle
}

//[CreateAssetMenu(fileName = "Items", menuName = "ScriptableObjects/Items")]
//public class Items : ScriptableObject
//{
//   [SerializeField] private GameObject _circle;
//   [SerializeField] private GameObject _square;
//   [SerializeField] private GameObject _triagle;

//    private Dictionary<FigureType, GameObject> _items;

//    public Dictionary<FigureType, GameObject> ArrayItems { get => _items; private set => _items = value; }

//    private void Awake()
//    {
//        _items = new Dictionary<FigureType, GameObject>
//        {
//            { FigureType.circle, _circle },
//            { FigureType.square, _square },
//            { FigureType.triagle, _triagle },
//        };
//    }
//}
