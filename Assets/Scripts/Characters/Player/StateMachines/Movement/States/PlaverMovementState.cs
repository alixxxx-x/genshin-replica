using UnityEngine;

namespace GenshinReplica
{
    public class PlaverMovementState : IState
    {
        public void Enter() 
        {
            Debug.log("State: " + GetType().Name);
        }

        public void Exit() 
        {

        }
        public void HandleInput() 
        {

        }
        public void Update() 
        {

        }
        public void PhysicsUpdate() 
        {
            
        }
    }

}
