using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    //2- Setter Injection Sample
    public class GameSetter
    {
        private IPlayer _player;
        public IPlayer Player { set { _player = value; } }

        public void StartGame()
        {
            _player.Play();
        }
    }
}
