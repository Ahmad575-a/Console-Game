using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string key, out int x, out int y)
    {
      switch (key)
      {
        case "DownArrow":
          x = 0;
          y = 1;
          break;
        case "UpArrow":
          x = 0;
          y = -1;
          break;
        case "RightArrow":
          x = 1;
          y = 0;
          break;
        case "LeftArrow":
          x = -1;
          y = 0;
          break;
        default:
          x = 0;
          y = 0;
          break;
      }
    }
    public new static char UpdateCursor(string key)
    {        
      switch (key)
      {
        case "LeftArrow":
          return '<';
        case "RightArrow":
          return '>';
        case "UpArrow":
          return '^';
        case "DownArrow":
          return 'v';
        default:
          return '<';
      }
    }
    public new static int KeepInBounds(int coordinate, int maxValue)
    {
     if(coordinate >= maxValue)
            { return maxValue -1; }
     else if(coordinate < 0)
            { return 0; }
     else 
            { return coordinate; }
    }
    public new static bool DidScore(int x1, int x2, int y1, int y2)
    {
       if (x1 == x2 && y1 == y2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}