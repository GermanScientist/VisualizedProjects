using Raylib_cs;

namespace VisualizedProjects.Visualizer {
    namespace VisualizedProjects.FiniteStateMachine {
        class FSM_Player: FSM_Actor {
            public FSM_Player(int _x, int _y, int _width, int _height, Color _color) : base(_x, _y, _width, _height, _color) {
                CellColor = Color.GREEN;
            }
        }
    }
}
