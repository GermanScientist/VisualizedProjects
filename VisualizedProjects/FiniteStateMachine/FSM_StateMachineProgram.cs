using Raylib_cs;

namespace VisualizedProjects.Visualizer {
    namespace VisualizedProjects.FiniteStateMachine {
        class FSM_StateMachineProgram : V_ProgramBase {
            public FSM_StateMachineProgram() {
            }

            public override void Update() {
                for (int i = 0; i < 10; i++) {
                    for (int j = 0; j < 10; j++) {
                        Raylib.DrawRectangle(i * 50, j * 50, 50, 50, Color.WHITE); //Draw the cell rectangle
                        Raylib.DrawRectangleLines(i * 50, j * 50, 50, 50, Color.BLACK); //Draw the cell outline
                    }
                }
            }
        }
    }
}