using Raylib_cs;
using System.Collections.Generic;
using System;

namespace VisualizedProjects.Visualizer {
    namespace VisualizedProjects.FiniteStateMachine {
        class FSM_StateMachineProgram : V_ProgramBase {

            private List<List<FSM_Cell>> grid; //The grid list
            private int columnsAmount; //The amount of columns (horizontally)
            private int rowsAmount; //The amount of rows (vertically)
            private int cellWidth; //The cell width
            private int cellHeight; //The cell height

            public FSM_StateMachineProgram() {
                //Initialize the properties
                columnsAmount = 50;
                rowsAmount = 50;

                //Set the width and height of the cells depending on the screensize
                cellWidth = (int)V_Settings.ScreenSize.X / columnsAmount; ;
                cellHeight = (int)V_Settings.ScreenSize.Y / rowsAmount; ;

                //Create a 2 dimensional list of cells
                grid = new List<List<FSM_Cell>>(columnsAmount);
                for (int i = 0; i < columnsAmount; i++) {
                    grid.Add(new List<FSM_Cell>(rowsAmount));
                    for (int j = 0; j < columnsAmount; j++)
                        grid[i].Add(new FSM_Cell(i, j,cellWidth, cellHeight, Color.WHITE)); //Cell(x, y, width, height)
                }

                //Start the setup
                Setup();
            }

            public override void Setup() {
                FSM_Cell playerGrid = grid[0][0];
                FSM_Cell enemyGrid = grid[columnsAmount - 1][rowsAmount - 1];
                grid[0][0] = new FSM_Player(playerGrid.X, playerGrid.Y, playerGrid.Width, playerGrid.Height, playerGrid.CellColor); //Assign the player cell
                grid[columnsAmount - 1][rowsAmount - 1] = new FSM_Enemy(enemyGrid.X, enemyGrid.Y, enemyGrid.Width, enemyGrid.Height, enemyGrid.CellColor); //Assign the enemy cell
            }

            public override void Update() {
                //Draw the cells
                for (int i = 0; i < columnsAmount; i++) {
                    for (int j = 0; j < rowsAmount; j++) {
                        grid[i][j].DrawCell();
                    }
                }   
            }
        }
    }
}