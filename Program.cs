using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PigProject_compsci
{

    class AI
    {

        public string id = new Guid().ToString();
        static int currentTurns = 0;

        static int saveAfter;

        public AI(int maximumSave)
        {
            saveAfter = maximumSave;
        }

        public void AITurn(object sender, EventArgs e)
        {

        }

        public void Run(Game instance)
        {

            // Event
            instance.BroadcastTurn += AITurn;
        }
    }

    class Program
    {

        static bool using_AI = false;
        static int ai_opponents = 2;
        static List<AI> opponents = new List<AI>();

        public void _benchmark_ai(Game instance)
        {

            for (int i = 0; i < ai_opponents; i++)
            {
                AI opponent = new AI(3);
                opponent.Run(instance);
                opponents.Add(opponent);
                instance.players.Add(opponent.id, 0);
            }

        }

        public void Main(string[] args)
        {

            //Game inst = new Game(true, 5000, false);
            //inst.Run();

            // For AI
            Game inst = new Game(false, 0, true);
            _benchmark_ai(inst);
            
        }
    }

}
