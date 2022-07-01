using System;
using UnityEngine;

namespace Game.AI
{
    [RequireComponent(typeof(EnemyStateMachineAI))]
    [DisallowMultipleComponent]
    public class StateProvider<T> : MonoBehaviour
    {
        public T state;

        private void Awake()
        {
            var a = GetComponent<EnemyStateMachineAI>();
            a.AddState(state as State);
        }
    }
    
}