﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramView{

    private ProgramModel model; 
    private string stringProgramCommand = "";
    public static readonly string[] InstructionsToString = new string[12];

    public void SetProgramModel(ProgramModel model){
        this.model = model;
    }

    public void DisplayPrgramInstructions(ProgramModel.ProgramInstructions programDisplay)
    {
        stringProgramCommand= model.GetProgramInstructions(programDisplay);
    }  
}
