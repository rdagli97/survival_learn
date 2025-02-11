using UnityEngine;

public class PlayerRunState : PlayerState
{
    public PlayerRunState(Player _player, PlayerStateMachine _stateMachine) : base(_player, _stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Im in Run state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Im out of Run State");
    }

    public override void Update()
    {
        base.Update();
        SetXandYInput();

        if(xInput == 0 && yInput == 0)
            stateMachine.ChangeState(player.idleState);
    }

    private void SetXandYInput()
    {
        player.anim.SetFloat("xVelocity", xInput);
        player.anim.SetFloat("zVelocity", yInput);
    }
}
