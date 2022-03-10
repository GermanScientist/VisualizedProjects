namespace VisualizedProjects.Visualizer {
    namespace VisualizedProjects.FiniteStateMachine {
        namespace VisualizedProjects.PathFinding {
            class Program {
                static void Main(string[] args) {
                    //Visualizer visualizer = new Visualizer("Pathfinding", new Pathfindinder()); //Create a window that runs the pathfinding program
                    //while (visualizer.Run()) {; } //Create an update loop to start running the application

                    Visualizer visualizer = new Visualizer("State Machine", new StateMachineProgram()); //Create a window that runs the pathfinding program
                    while (visualizer.Run()) {; } //Create an update loop to start running the application
                }
            }
        }
    }
}
