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
  }
}