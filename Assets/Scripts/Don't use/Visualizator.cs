//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Threading;
//using UnityEditor;
//using UnityEditor.Animations;
//using UnityEngine;
//using UnityEngine.SocialPlatforms.GameCenter;
//using UnityEngine.UI;
//using System = System.Random;


//public class Visualizator : MonoBehaviour
//{
//    #region GameObjectField
//    [SerializeField] private GameObject _circle;
//    [SerializeField] private GameObject _square;
//    [SerializeField] private GameObject _triagle;
//    #endregion GameObjectField


//    #region positionSpawn
//    private Vector3 _positionSpawn;
//    private float _maxX;
//    private float _maxY;
//    private float _hight;
//    private float _widht;
//    #endregion positionSpawn

//    bool isOn = true;

//    private void Start()
//    {
//        Timer _timer = Instantiate.(_timer, new Vector3(0, 0, 0), Quaternion.identity);

//        _hight = GetComponent<RectTransform>().rect.height;
//        _widht = GetComponent<RectTransform>().rect.width;
//        CheckSwitchFigure();
//        GameObject[] _gameObjectArray = { _circle, _square, _triagle };
//        ChoseObject(_gameObjectArray);
//    }

//    private void Update()
//    {
//        TimerToSpawn(float timeToCreate);
//        DestroyTimer();
//        ShowTimerToObject();



//        ShowTimerToObject(float _timeRandomForDestroy);
//    }

//    public void CheckSwitchFigure()//Toggle
//    {

//    }

//    public void ChoseObject(GameObject[] _gameObjectArray)
//    {
//        int nextIndexShape = (int)(UnityEngine.Random.Range(0, _gameObjectArray.Length - 1));
//        GameObject nextShape = _gameObjectArray[nextIndexShape];
//        SpawnObject(nextShape);
//    }

//    public void PositionSpawn()
//    {
//        float _maxX = _widht / 2;
//        float _maxY = _hight / 2;
//        float randomX = UnityEngine.Random.Range(-_maxX, _maxX);
//        float randomY = UnityEngine.Random.Range(-_maxY, _maxY);
//        _positionSpawn = new Vector3(randomX, randomY, 0f);
//    }

//    public void SpawnObject(GameObject nextShape)
//    {
//        PositionSpawn();
//        Instantiate(nextShape, _positionSpawn, Quaternion.identity);
//        _timer.RandomValueForTimerDestroy();//
//        Timer.RandomValueForTimerToSpawn();//
//    }


//    private void DestroyTimer(float timeRandomForDestroy, GameObject gameObject)
//    {
//        if (true)
//        {
//            if (timeRandomForDestroy > 0)
//            {
//                timeRandomForDestroy -= Time.deltaTime;
//            }
//            else
//            {
//                ShowTimerToObject(float _timeRandomForDestroy)
//                Destroy(gameObject);
//            }
//        }

//    }

//    private void ShowTimerToObject(float _timeRandomForDestroy)
//    {
//        GameObject. =
//        Debug.Log(Math.Round(_timeRandomForDestroy, 1).ToString()); // Передать в Таймер на Объекте(Text)
//    }
//}