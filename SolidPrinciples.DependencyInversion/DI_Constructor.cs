using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    //1- Constructor Injection Sample 
    public class GameConstruction
    {
        IPlayer _player;
        public GameConstruction(IPlayer player)
        {
            this._player = player;
        }

        public void StartGame()
        {
            _player.Play();
        }
    }
}
