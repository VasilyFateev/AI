using System.Collections.Generic;
using Game.AI;
using UnityEngine;

namespace Game
{
    public class EnemyStateMachineAI : MonoBehaviour
    {
        [SerializeReference] private List<State> states;

        internal void AddState(State state)
        {
            states.Add(state);
        }
    }
}