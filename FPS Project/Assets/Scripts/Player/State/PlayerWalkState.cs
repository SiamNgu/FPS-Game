using UnityEngine;
public class PlayerWalkState : PlayerBaseState
{
    public override void Execute(PlayerStateMachine player)
    {
        player.animatorComponent.SetBool("Jumping", false);
        player.animatorComponent.SetFloat("Speed", 0.5f);
        player.rigidbodyComponent.AddRelativeForce(new Vector3(player.moveVector.x, 0, player.moveVector.y) * player.walkSpeed, ForceMode.Force);
        if (player.jumpKeyPressed)
        {
            player.SwitchState(player.playerJumpState);
        }
        if (!player.moveKeysPressed)
        {
            player.SwitchState(player.playerIdleState);
        }
        if (player.runKeyPressed)
        {
            player.SwitchState(player.playerRunState);
        }
    }
}
