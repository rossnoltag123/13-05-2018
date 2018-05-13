using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProgramController{

    private BoardController boardController;
    private ProgramModel model;
    private ProgramView view;
    public List<ProgramModel.ProgramInstructions> programInstructionList = new List<ProgramModel.ProgramInstructions>();

    public void SetBoardController(BoardController boardController){
        this.boardController = boardController;
    }

    public void AddInstructionToList(ProgramModel.ProgramInstructions instruction){
        programInstructionList.Add(instruction);
    }

    public void PlayCommands(){
        foreach (ProgramModel.ProgramInstructions instruction in programInstructionList){
            InstructionPointer(instruction);
        }      
    }

    public void ShowCommandsListInConsole(){
        foreach (ProgramModel.ProgramInstructions instruction in programInstructionList)
            Debug.Log(instruction);
    }

    public void ClearCommandsList(){
        programInstructionList.Clear();
    }

    public void InstructionPointer(ProgramModel.ProgramInstructions instruction){
        switch (instruction)
        {     
            case ProgramModel.ProgramInstructions.LIGHTUP:
                boardController.LightUpSquare();
                break;
            case ProgramModel.ProgramInstructions.WALK_NORTH:
                boardController.Walk(BoardModel.CompassDirection.NORTH);
                break;       
            case ProgramModel.ProgramInstructions.WALK_SOUTH:
                boardController.Walk(BoardModel.CompassDirection.SOUTH);
                break;  
            case ProgramModel.ProgramInstructions.WALK_EAST:
                boardController.Walk(BoardModel.CompassDirection.EAST);
                break;
            case ProgramModel.ProgramInstructions.WALK_WEST:
                boardController.Walk(BoardModel.CompassDirection.WEST);
                break;
            case ProgramModel.ProgramInstructions.JUMP_NORTH:
                boardController.Jump(BoardModel.CompassDirection.NORTH);
                break;
            case ProgramModel.ProgramInstructions.JUMP_SOUTH:
                boardController.Jump(BoardModel.CompassDirection.SOUTH);
                break;
            case ProgramModel.ProgramInstructions.JUMP_EAST:
                boardController.Jump(BoardModel.CompassDirection.EAST);
                break;            
            case ProgramModel.ProgramInstructions.JUMP_WEST:
                boardController.Jump(BoardModel.CompassDirection.WEST);
                break; 
        }
    }
   
}
