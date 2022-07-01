using UnityEngine;

namespace Game.AI
{
    [System.Serializable]
    public class PursuitState : State
    {
        [SerializeField] private Transform playerTransform;

        internal override void StateAction()
        {
            throw new System.NotImplementedException();
        }
    }
}