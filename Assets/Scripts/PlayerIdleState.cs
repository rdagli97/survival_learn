using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine) : base(_player, _stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Im in idle state");

    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Im out of idle state");
    }

    public override void Update()
    {
        base.Update();

        if(xInput != 0 || yInput != 0)
            stateMachine.ChangeState(player.runState);
    }
}
