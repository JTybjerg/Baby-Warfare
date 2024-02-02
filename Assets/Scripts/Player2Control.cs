using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controls : CommonControls
{

    protected override void GatherInput()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal_Player2"), 0, Input.GetAxisRaw("Vertical_Player2"));

        // Handle Player 2 input logic
    }
}
