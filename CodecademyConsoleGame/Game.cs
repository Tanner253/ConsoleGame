using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string key, out int x, out int y)
        {
            /*if(key == "DownArrow"){
                y++;
            }else if(key == "UpArrow"){
                y--;
            }else if(key == "LeftArrow"){
                x++;
            }else if(key == "RightArrow"){
                x--;
            }*/
            switch (key){
            case "DownArrow":
                    y++;
                    break;
            case "UpArrow":
                    y--;
                    break;
            case "LeftArrow":
                    x++;
                    break;
            case "RightArrow":
                    x--;
                    break;
            }
	
        }

        public new static char UpdateCursor(string key){
            switch(key){
            case "Leftarrow":
                return '<';
                        break;
            case "RightArrow":
                    return '>';
                    break;
            case "UpArrow":
                    return '^';
                    break;
            case "DownArrow":
                    return 'v';
                    break;
            }
        }
        public new static int KeepInBounds(int coords, int maxVal){
            if(coords > 10)
            {
            coords == 9;
            }else if(coords < 0)
            {
            coords == 0;
            }
        }
        public new static bool DidScore(int x, int y, int fx, int fy){
            if(x == fx && y == fy);
        }
  }
}