using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    //3- Method Injection
    public interface IGameInterface
    {
        void StartGame(IPlayer player);
    }

    public class GameInterface : IGameInterface
    {
        private IPlayer _player;
        public void StartGame(IPlayer player)
        {
            this._player = player;
            _player.Play();
        }
    }
}
