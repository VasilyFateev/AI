using UnityEngine;

namespace Game.AI
{
    [System.Serializable]
    public class PatrolState : State
    {
        [SerializeField] private GameObject[] WayPoints;
        internal override void StateAction()
        {
            throw new System.NotImplementedException();
        }
    }
}