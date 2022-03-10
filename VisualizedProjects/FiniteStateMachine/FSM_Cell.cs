using Raylib_cs;

namespace VisualizedProjects.Visualizer {
    namespace VisualizedProjects.FiniteStateMachine {
        class FSM_Cell {
            //Properties
            private int x; //The x position of the cell
            private int y; //The y position of the cell

            private int width; //Cell width
            private int height; //Cell height
            
            private Color cellColor; //Cell height

            //The cell positions
            public int X { get { return x; } }
            public int Y { get { return y; } }

            //The cell size
            public int Width { get { return width; } }
            public int Height { get { return height; } }

            public Color CellColor { get { return cellColor; } protected set { cellColor = value; } }

            public FSM_Cell(int _x, int _y, int _width, int _height, Color _color) {
                //The cell positions and size
                x = _x;
                y = _y;
                width = _width;
                height = _height;

                //The cell color
                cellColor = _color;
            }

            //Draw the cell
            public void DrawCell() {
                Raylib.DrawRectangle(x * width, y * height, width, height, cellColor); //Draw the cell rectangle
                Raylib.DrawRectangleLines(x * width, y * height, width, height, Color.BLACK); //Draw the cell outline
            }
        }
    }
}