using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
    public class EnemyCollection 
    {
        [SerializeField] private List<GameObject> Spwaner;

        public List<GameObject> Enemies { get { return Spwaner; } }
    }
