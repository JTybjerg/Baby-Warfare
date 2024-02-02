using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : CommonControls
{

    protected override void GatherInput()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        // Handle Player 1 input logic
    }
}
