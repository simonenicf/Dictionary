using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dungeon myDung = new Dungeon();
            Dungeon mySecDung = new Dungeon();
            myDung.roomInfo("Room1");
            mySecDung.roomInfo("Room4");
            
        }
    }

    class Dungeon
    {
        Dictionary<string, Room> dungeonLayout = new Dictionary<string, Room>();
        
        public Dungeon()
        {
            dungeonLayout.Add("Room1", new Room(10, 5));
            dungeonLayout.Add("Room2", new Room(10, 6));
        }
        
        public void roomInfo(string roomName)
        {
            Room myRoomvalue;
            if(!dungeonLayout.TryGetValue(roomName, out myRoomvalue))
            {
                Console.WriteLine("This key doesn't exist in this dictonary");
                return;
            }
            Console.WriteLine(myRoomvalue.makeString());
            myRoomvalue.getCoords();
            myRoomvalue.callAllEnemyLogic();
        }
    }

    class Room
    {
        private int worldX;
        private int worldY;

        public Room(int worldX, int worldY)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        
        public List<Enemy> enemies = new List<Enemy>()
        {
            new Enemy(),
            new Enemy(),
            new Enemy()
        };

        public string makeString()
        {
            return "world cords : " + worldX.ToString() + "," + worldY.ToString();
        }
        public int[] getCoords()
        {
            int[] myCords = { worldX, worldY };
            return myCords;
        }

        public void callAllEnemyLogic()
        {
            foreach (Enemy aEnemy in enemies)
            {
                aEnemy.logic();
            }
        }

    }

    class Enemy
    {
        public void logic()
        {
            // checks if this funcion gets called
            Console.WriteLine("works");
        }

    }
}
