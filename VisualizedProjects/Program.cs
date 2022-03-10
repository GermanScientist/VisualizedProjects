namespace VisualizedProjects.Visualizer {
    namespace VisualizedProjects.FiniteStateMachine {
        namespace VisualizedProjects.PathFinding {
            class Program {
                static void Main(string[] args) {
                    //V_Visualizer visualizer = new V_Visualizer("Pathfinding", new PF_Pathfinder()); //Create a window that runs the pathfinding program
                    //while (visualizer.Run()) {; } //Create an update loop to start running the application

                    V_Visualizer visualizer = new V_Visualizer("State Machine", new FSM_StateMachineProgram()); //Create a window that runs the pathfinding program
                    while (visualizer.Run()) {; } //Create an update loop to start running the application
                }
            }
        }
    }
}
