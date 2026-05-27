using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinReplica
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public PlayerIdlingState IdlingState { get; }
        public PlayerWalkingState WalkingState { get; }
        public PlayerRunningState RunningState { get; }
        public PlayerSprintingState SprintingState { get; }

        public PlayerMovementStateMachine()
        {
            IdlingState = new PlayerIdingState();
            
            WalkingState = new PlayerWalkingState();
            RunningState = new PlayerRunningState();
            SprintingState = new PlayerSprintingState();

        }

    }
}
