using UnityEngine;

namespace GenshinReplica
{   
    [RequireComponent(typeof(PlayerInput))]
    public class Player : MonoBehaviour
    {
        public Rigidbody rigidbody {get; private set;}
        
        public PlayerInput Input {get; private set;}

        private PlayerMovementStateMachine movementStateMachine;

        private void Awake() {
            rigidbody = GetComponent<Rigidbody>();
            movementStateMachine = new PlayerMovementStateMachine(this);
            Input = GetComponent<PlayerInput>();
        }

        private void Start() {
            movementStateMachine.ChangeState(movementStateMachine.IdlingState);
        }

        private void Update() {
            movementStateMachine.HandleInput();
            movementStateMachine.Update();
        }

        private void FixedUpdate() {
            movementStateMachine.PhysicsUpdate();
        }



    }
}
