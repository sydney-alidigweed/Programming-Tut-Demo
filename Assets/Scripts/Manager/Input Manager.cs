using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class InputManager
{
    private static Controls _controls;
    public static void init(Player myPlayer)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());

            myPlayer.setState(Player.EMovementState.Moving);
        };

        _controls.Game.Jump.performed += ctx =>
        {
            myPlayer.SetJump();

            myPlayer.setState(Player.EMovementState.Jumping);
        };

        _controls.Game.Shoot.performed += ctx =>
        {
            myPlayer.Shoot();
        };

        _controls.Game.Reload.performed += ctx =>
        {
            myPlayer.Reload();
        };

        _controls.Permanents.Enable();

    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void uiMode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();
    }
    //_controls.Game.Movement.canceled += ctx =>
    //{
    //    myPlayer.setState(Player.EMovementState.Idle);
    //};
}
