using Raylib_cs;

namespace VisualizedProjects.Visualizer {
    namespace VisualizedProjects.FiniteStateMachine {
        class FSM_Cell {
            //Properties
            private int x; //The x position of the cell
            private int y; //The y position of the cell

            private int width; //Cell width
            private int height; //Cell height
            
            private Color color; //Cell height

            //The cell positions
            public int X { get { return x; } }
            public int Y { get { return y; } }

            public FSM_Cell(int _x, int _y, int _width, int _height, Color _color) {
                //The cell positions and size
                x = _x;
                y = _y;
                width = _width;
                height = _height;

                //The cell color
                color = _color;
            }

            //Draw the cell
            public void DrawCell(Color _cellColor) {
                Raylib.DrawRectangle(x * width, y * height, width, height, _cellColor); //Draw the cell rectangle
                Raylib.DrawRectangleLines(x * width, y * height, width, height, Color.BLACK); //Draw the cell outline
            }
        }
    }
}